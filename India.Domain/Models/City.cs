using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace India.Domain.Models
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BigInteger Population { get; set; }
        public Guid StateId { get; set; }

        //navigation properties
        public State State { get; set; }
    }
}
