using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Population
    {
        public int PopulationId { get; set; }
        public int Size { get; set; }
        public int MinSize { get; set; }    
        public int MaxSize { get; set; }

        public List<Individual> Individuals { get; set; }

        public int GhostId { get; set; }
    }
}