using Helpers.Models.ContentModels;
using Helpers.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services.ProfilesServices
{
    public interface IPersonInfoService 
    {
        Task<PublicPageModel> GetPerson(string userLogin);
    }
}
