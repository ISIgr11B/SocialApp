using static Helpers.Models.Enums.Definitions;

namespace Helpers.Models.ContentModels
{
    public class PostModel
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public Visibility VisibilityType { get; set; }
    }

    
}
