using Ocit.Exercies.Emds.Domain.Intercaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocit.Exercies.Emds.Domain
{
    public class IncomingDocument : BasicDocument
    {
        public virtual List<Addresse> Addresse { get; set; }
        public virtual List<CounterParty> CounterParty { get; set; }
        public virtual List<DeliveryMethod> DeliveryMethod { get; set; }
        public virtual List<CameFrom> CameFrom { get; set; }
    }
}
