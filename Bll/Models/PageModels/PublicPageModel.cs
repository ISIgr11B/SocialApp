﻿using Bll.Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Models.PageModels
{
    /*Model wyświelanych informacji o stronie publicznej*/
    public class PublicPageModel
    {
        public PublicPersonModel PublicPerson { get; set; }
        public PhotoGalleryModel PhotosGallery {get;set;}
    }
}
