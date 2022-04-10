using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Individual
    {
        public int IndividualID { get; set; }
        public double Fitness { get; set; }
        public int Age { get; set; }

        public int PopulationId { get; set; }
        public Population OwnerPopulation { get; set; }
    }
}