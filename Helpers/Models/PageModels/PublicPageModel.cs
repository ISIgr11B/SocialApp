﻿using Helpers.Models.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Models.PageModels
{
    /*Model wyświelanych informacji o stronie publicznej*/
    public class PublicPageModel
    {
        public PublicPageModel Person { get; set; }
        public PhotoGalleryModel PhotosGallery { get; set; }
        public FriendsModel Friends { get; set; }
        public ContextWallModel ContextWall { get; set; }
    }
}
