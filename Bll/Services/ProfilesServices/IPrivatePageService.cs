using Helpers.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services.ProfilesServices
{
    public interface IPrivatePageService
    {
        /*Metoda zwracająca własną stronę*/
        Task<PrivatePageModel> GetOwnPage(string userIdentificator);
        Task<int> PostOwnPage(PrivatePageModel privatePage);
        Task<int> UpdateOwnPage(string userLogin, PrivatePageModel privatePage);
        Task<int> DeleteOwnPage(string userLogin);
    }
}
