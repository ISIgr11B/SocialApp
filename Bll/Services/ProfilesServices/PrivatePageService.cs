using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.Models.ContentModels;
using Bll.Models.PageModels;

namespace Bll.Services.ProfilesServices
{
    public class PrivatePageService : IPrivatePageService
    {
        public PrivatePageModel GetOwnPage()
        {
            var page = new PrivatePageModel
            {
                Person = new PersonModel { FirstName = "Jan", LastName = "Kowalski", Picture = "/images/ludziki.jpg" },
                Friends = new FriendsModel { Peoples = new List<PersonModel>
                    {
                        new PersonModel { FirstName = "Edward", LastName = "Nowak" , Picture = "/images/ludziki.jpg" },
                        new PersonModel { FirstName = "Paweł", LastName = "Janusz" , Picture = "/images/ludziki.jpg" }
                    }
                },
                PhotosGallery = new PhotoGalleryModel{ PhotosPath = new List<string>
                    {
                        "/images/ludziki.jpg","/images/ludziki.jpg","/images/ludziki.jpg"
                    }
                }
            };
            return page;
        }
    }
}
