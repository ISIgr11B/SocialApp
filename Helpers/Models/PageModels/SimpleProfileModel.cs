using Helpers.Models.ContentModels;
using Helpers.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.Models.PageModels
{
    public class SimpleProfileModel
    {
        public PublicPersonModel Person { get; set; }
        public PhotoModel Photo { get; set; }
    }
}
