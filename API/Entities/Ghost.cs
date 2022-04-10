using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Ghost
    {
        public int GhostId { get; set; }
        public int GenerationNumber { get; set; }
        public int LifeSpan { get; set; }
        public int Rating { get; set; }

        public int ProjectId { get; set; }
        public Project parentProject { get; set; }

        public int PopulationId { get; set; }

    }
}