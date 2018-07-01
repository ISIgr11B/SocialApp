using Helpers.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Models.ContentModels;

namespace Bll.Services.ProfilesServices
{
    public interface IPrivatePageService
    {
        /*Metoda zwracająca własną stronę*/
        PrivatePageModel GetOwnPage(string userIdentificator);

        int UpdateOwnData(PersonModel personModel);
    }
}
