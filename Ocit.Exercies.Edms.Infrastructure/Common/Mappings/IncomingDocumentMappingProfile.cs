using AutoMapper;
using Ocit.Exercies.Emds.Domain;
using Ocit.Exercies.Emds.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocit.Exercies.Edms.Infrastructure.Common.Mappings
{
    public class IncomingDocumentMappingProfile : Profile
    {
        public IncomingDocumentMappingProfile()
        {
            CreateMap<IncomingDocument, IncomingDocumentViewModel>()
                .IncludeBase<BasicDocument, BasicDocumentViewModel>()
                .ForMember(vm => vm.Addresse, 
                    opt => opt.MapFrom(
                        doc => string.Join(',', doc.Addresse.Select(x => x.FullName))))
                .ForMember(vm => vm.CameFrom,
                    opt => opt.MapFrom(
                        doc => string.Join(',', doc.CameFrom.Select(x => x.Name))))
                .ForMember(vm => vm.CounterParty,
                    opt => opt.MapFrom(
                        doc => string.Join(',', doc.CounterParty.Select(x => x.Name))))
                .ForMember(vm => vm.DeliveryMethod,
                    opt => opt.MapFrom(
                        doc => string.Join(',', doc.DeliveryMethod.Select(x => x.Name))));   
        }
    }
}
