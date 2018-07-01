using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Models.ContentModels;
using Dal.UnitOfWork;
using Helpers.Models.PageModels;

namespace Bll.Services.ProfilesServices
{
    public class PersonInfoService : ServiceBase, IPersonInfoService
    {
        public  PersonInfoService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public PublicPageModel GetPerson(string userLogin)
        {
            var result =  new PublicPageModel();
            return result;
        }
    }
}
