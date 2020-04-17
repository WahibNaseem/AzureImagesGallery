using System.Collections.Generic;

namespace AzureImagesGallery.Data.Domains.Models
{
    public class GalleryImage: BaseModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public virtual IEnumerable<ImageTag> Tags { get; set; }
    }
}
