using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Models.ContentModels
{
    public class PublicPersonModel
    {
        public string UserIdentificator { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime JoinDate { get; set; }
        public string Picture { get; set; }
        public string Gender { get; set; }
    }
}
