using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace India.Domain.Models
{
    public class City
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Population { get; set; }
        public Guid StateId { get; set; }

        //navigation properties
        public State State { get; set; }
    }
}
