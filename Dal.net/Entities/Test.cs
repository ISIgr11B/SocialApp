using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vive.Vcs.Visualisation.Dal.VisualisationDbContext.Entities;

namespace Dal.Entities
{
    public class Test : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
