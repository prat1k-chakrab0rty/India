using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace India.Domain.Models
{
    public class State
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Population { get; set; }
        public ICollection<City> Cities { get; set; }

        public Guid CapitalCityId { get; set; }
        // Navigation Properties
        [ForeignKey("CapitalCityId")]
        public City CapitalCity { get; set; }
    }
}
