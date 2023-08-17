using Ocit.Exercies.Emds.Domain.Intercaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocit.Exercies.Emds.Domain
{
    public class CameFrom : IHaveId
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
