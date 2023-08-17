using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Ocit.Exercies.Edms.Infrastructure.Common.Commands.Common;
using Ocit.Exercies.Edms.Infrastructure.Common.Enums;
using Ocit.Exercies.Emds.Domain;
using Ocit.Exercies.Emds.Domain.Enums;
using Ocit.Exercies.Emds.Domain.Intercaces;
using Ocit.Exercies.Emds.Domain.ViewModels;
using Ocit.Exezrcies.Emds.Data.Interfaces;

namespace Ocit.Exercies.Edms.Infrastructure.Common.Commands.LoadRegistry
{
    public class LoadRegestryQuery : ILoadRegistry<IViewModel>
    {
        public RegistryType RegistryType { get; set; }

        public LoadRegestryQuery(RegistryType registryType)
        {
            RegistryType = registryType;
        }
    }

    public class LoadRegestryQueryHandler : IRequestHandler<LoadRegestryQuery, IEnumerable<IViewModel>>
    {
        private readonly IAppDbContext _context;
        private readonly IMapper _mapper;

        public LoadRegestryQueryHandler(IAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<IViewModel>> Handle(LoadRegestryQuery request, CancellationToken cancellationToken) 
        {
            return request.RegistryType switch
            {
                RegistryType.Basic => await _context.BasicDocuments
                                        .Where(x => x.DocumentKind.Contains(DocumentKind.BasicDocument))
                                        .ProjectTo<BasicDocumentViewModel>(_mapper.ConfigurationProvider)
                                        .ToListAsync(cancellationToken),
                RegistryType.Incoming => await _context.IncomingDocuments
                                        .Where(x => x.DocumentKind.Contains(DocumentKind.IncomingDocument))
                                        .ProjectTo<IncomingDocumentViewModel>(_mapper.ConfigurationProvider)
                                        .ToListAsync(cancellationToken),
                _ => new List<IViewModel>(),
            };
        }
    }
}
