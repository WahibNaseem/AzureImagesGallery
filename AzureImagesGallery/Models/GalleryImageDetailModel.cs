using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureImagesGallery.Models
{
    public class GalleryImageDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime CreatedOn { get; set; }

        public List<string> Tags { get; set; }
    }
}
