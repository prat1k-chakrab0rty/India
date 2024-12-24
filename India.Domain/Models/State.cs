using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace India.Domain.Models
{
    public class State
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BigInteger Population { get; set; }
        public ICollection<City> Cities { get; set; }

        public Guid CapitalCityId { get; set; }
        // Navigation Properties
        public City CapitalCity { get; set; }
    }
}
