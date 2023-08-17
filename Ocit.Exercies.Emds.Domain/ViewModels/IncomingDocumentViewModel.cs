using Ocit.Exercies.Emds.Domain.Intercaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocit.Exercies.Emds.Domain.ViewModels
{
    public class IncomingDocumentViewModel : BasicDocumentViewModel
    {
        public string Addresse { get; set; }
        public string CounterParty { get; set; }
        public string DeliveryMethod { get; set; }
        public string CameFrom { get; set; }
    }
}
