using System;
using System.ComponentModel;

namespace Helpers.Models.ContentModels
{
    public class PublicPersonModel
    {
        [DisplayName("Login")]
        public string UserIdentificator { get; set; }
        [DisplayName("Imię")]
        public string FirstName { get; set; }
        [DisplayName("Nazwisko")]
        public string LastName { get; set; }
        [DisplayName("Data urodzenia")]
        public DateTime Birthdate { get; set; }
        [DisplayName("Data dołączenia")]
        public DateTime JoinDate { get; set; }
        [DisplayName("Zdjęcie")]
        public string Picture { get; set; }
        [DisplayName("Płeć")]
        public string Gender { get; set; }
    }
}
