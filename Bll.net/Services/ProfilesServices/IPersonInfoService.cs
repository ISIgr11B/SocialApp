using Bll.Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services.ProfilesServices
{
    public interface IPersonInfoService 
    {
        Task<PublicPersonModel> GetPerson(string userLogin);
    }
}
