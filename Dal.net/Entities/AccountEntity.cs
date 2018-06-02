using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Vive.Vcs.Visualisation.Dal.VisualisationDbContext.Entities;

namespace Dal.Entities
{
    public class AccountEntity : IEntity
    {
        [Key, Required]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserLogin { get; set; }
        [Required]
        public string UserIdentificator { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required, 
            DataType(DataType.Password),
            Display(Name ="Hasło"),
            RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$)")]
        public SecureString Password { get; set; }
    }
}
