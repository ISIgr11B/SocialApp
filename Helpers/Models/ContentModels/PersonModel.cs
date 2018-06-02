using System.ComponentModel;

namespace Helpers.Models.ContentModels
{
    public class PersonModel : PublicPersonModel
    {
        [DisplayName("E-Mail")]
        public string Mail { get; set; }
    }
}
