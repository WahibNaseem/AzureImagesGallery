using System;
using System.Collections.Generic;
using System.Text;

namespace AzureImagesGallery.Data.Domains.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }
}
