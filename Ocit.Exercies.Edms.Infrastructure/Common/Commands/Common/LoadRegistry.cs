using MediatR;
using Ocit.Exercies.Edms.Infrastructure.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocit.Exercies.Edms.Infrastructure.Common.Commands.Common
{
    public interface ILoadRegistry<TType> : IRequest<IEnumerable<TType>>
    {
        public RegistryType RegistryType { get; }
    }
}
