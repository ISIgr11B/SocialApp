﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.Models.ContentModels;
using Helpers.Models.PageModels;
using Dal.UnitOfWork;
using Helpers.Models.DataModels;

namespace Bll.Services.ProfilesServices
{
    public class PrivatePageServiceMemory : ServiceBase, IPrivatePageService
    {
        public PrivatePageServiceMemory(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public int DeleteOwnPage(string userLogin)
        {
            throw new NotImplementedException();
        }

        public PrivatePageModel GetOwnPage(string userIdentificator)
        {
            var page = new PrivatePageModel
            {
                Person = new PersonModel { FirstName = "Jan", LastName = "Kowalski", Picture = "/images/ludziki.jpg" },
                Friends = new FriendsModel
                {
                    Peoples = new List<SimpleProfileModel>
                    {
                        new SimpleProfileModel{
                            Person= new PersonModel { FirstName = "Edward", LastName = "Nowak" , Picture = "/images/ludziki.jpg" },
                            Photo = new PhotoModel()
                        },
                        new SimpleProfileModel{
                            Person = new PersonModel { FirstName = "Paweł", LastName = "Janusz" , Picture = "/images/ludziki.jpg" },
                            Photo = new PhotoModel()
                        }
                    }
                },
                PhotosGallery = new PhotoGalleryModel
                {
                    PhotosPath = new List<PhotoModel>
                    {
                        new PhotoModel { Path="/images/ludziki.jpg" },
                        new PhotoModel { Path="/images/ludziki.jpg" },
                        new PhotoModel { Path="/images/ludziki.jpg" }
                    }
                },
                ContextWall = new ContextWallModel
                {
                    Posts = new List<PostModel>
                    {
                        new PostModel{Header = "Nagłówek 1", Body="Piszę o świecie"},
                        new PostModel{Header = "Nagłówek 2", Body="Piszę o Marsie"}
                    }
                }
            };
            return page;
        }

        public int UpdateOwnData(PersonModel personModel)
        {
            throw new NotImplementedException();
        }


    }
}
