using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vive.Vcs.Visualisation.Dal.VisualisationDbContext.Entities;

namespace Dal.Entities
{
    public class UserEntity : IEntity
    {
        [Key,Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime JoinDate { get; set; }
        public string Gender { get; set; }

        public AccountEntity Account { get; set; }
    }
}
