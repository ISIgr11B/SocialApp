using Bll.Models.PageModels;
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
        Task<int> PostOwnPage(string userLogin);
        Task<int> UpdateOwnPage(string userLogin);
        Task<int> DeleteOwnPage(string userLogin);
    }
}
