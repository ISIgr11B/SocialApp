using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Dal.UnitOfWork;
using Helpers.Models.ContentModels;
using Helpers.Models.PageModels;

namespace Bll.Services.ProfilesServices
{
    public class PrivatePageService : ServiceBase,IPrivatePageService
    {
        public PrivatePageService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PrivatePageModel GetOwnPage(string userIdentificator)
        {
            var model = new PrivatePageModel();;

            var person = base._unitOfWork.UserRepository.Find(x => x.UserIdentificator == userIdentificator);
            if (person == null)
                return null;
            model.Person = new PersonModel
            {
                UserIdentificator = userIdentificator,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Birthdate = person.Birthdate,
                Gender = person.Gender,
                JoinDate = person.JoinDate,
                Mail = person.Mail
            };

            return model;
        }

        public int UpdateOwnData(PersonModel personModel)
        {
            var person = base._unitOfWork.UserRepository.Find(x => x.UserIdentificator == personModel.UserIdentificator);
            if (person == null)
                return -1;

            person.FirstName = personModel.FirstName;
            person.LastName = personModel.LastName;
            person.Birthdate = personModel.Birthdate;
            person.Gender = personModel.Gender;
            person.JoinDate = personModel.JoinDate;
            person.Mail = personModel.Mail;
            _unitOfWork.UserRepository.Update(person);

            return _unitOfWork.Commit();
        }

        public int AddPost(string userIdentificator, PostModel post)
        {
            var person = base._unitOfWork.UserRepository.Find(x => x.UserIdentificator == userIdentificator);
            if (person == null)
                return -1;
            var postEntity = new PostEntity
            {
                Body = post.Body,
                Header = post.Header,
                VisibilityType = post.VisibilityType,
                User = person
            };
            _unitOfWork.PostRepository.Add(postEntity);
            return _unitOfWork.Commit();
        }
    }
}
