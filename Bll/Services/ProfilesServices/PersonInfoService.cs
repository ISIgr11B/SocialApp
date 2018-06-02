using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Models.ContentModels;
using Dal.UnitOfWork;

namespace Bll.Services.ProfilesServices
{
    public class PersonInfoService : ServiceBase, IPersonInfoService
    {
        public  PersonInfoService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async  Task<PublicPersonModel> GetPerson(string userLogin)
        {
            var result =  new PublicPersonModel();
            return result;
        }
    }
}
