using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int AppUserId { get; set; }
        public AppUser ProjectOwner { get; set; }

        public List<Ghost> Ghosts { get; set; }

    }
}