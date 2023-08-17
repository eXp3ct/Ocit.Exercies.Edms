using AutoMapper;
using Ocit.Exercies.Emds.Domain;
using Ocit.Exercies.Emds.Domain.ViewModels;

namespace Ocit.Exercies.Edms.Infrastructure.Common.Mappings
{
    public class BasicDocumentMappingProfile : Profile
    {
        public BasicDocumentMappingProfile()
        {
            CreateMap<BasicDocument, BasicDocumentViewModel>()
                .ForMember(vm => vm.DocumentKind,
                    opt => opt.MapFrom(doc => 
                        string.Join(',', doc.DocumentKind)));
        }
    }
}
