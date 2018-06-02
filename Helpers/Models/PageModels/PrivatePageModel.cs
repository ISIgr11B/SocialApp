using Helpers.Models.ContentModels;

namespace Helpers.Models.PageModels
{
    /*Model wyświelanych informacji o stronie prywatne*/
    public class PrivatePageModel
    {
        public PersonModel Person { get; set; }
        public PhotoGalleryModel PhotosGallery { get; set; }
        public FriendsModel Friends { get; set; }
        public ContextWallModel ContextWall { get; set; }
    }
}
