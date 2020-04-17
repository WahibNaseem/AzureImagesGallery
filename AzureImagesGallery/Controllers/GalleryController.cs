using AzureImagesGallery.Data.Domains.Models;
using AzureImagesGallery.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureImagesGallery.Controllers
{
    public class GalleryController : Controller
    {
        public GalleryController()
        {

        }

        public IActionResult Index()
        {
            var hikingImagesTags = new List<ImageTag>();
            var cityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag
            {
                Id = 0,
                Description = "Adventure",
                Created = DateTime.Now
            };

            var tag2 = new ImageTag
            {
                Id = 1,
                Description = "Urban",
                Created = DateTime.Now
            };

            var tag3 = new ImageTag
            {
                Id = 2,
                Description = "New York",
                Created = DateTime.Now
            };

            hikingImagesTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTag> { tag2, tag3 });

            var imageList = new List<GalleryImage>
            {
                new GalleryImage
                {
                     Title = "Hiking Trip",
                     Url = "https://images.pexels.com/photos/1271619/pexels-photo-1271619.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940",
                     Created = DateTime.Now,
                     Tags = hikingImagesTags

                },

                new GalleryImage
                {
                    Title = "On The Trail",
                    Url = "https://images.pexels.com/photos/701016/pexels-photo-701016.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940",
                    Created = DateTime.Now,
                    Tags = hikingImagesTags
                },

                new GalleryImage
                {
                    Title = "DownTown",
                    Url = "https://images.pexels.com/photos/830891/pexels-photo-830891.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                }

            };

            var model = new GalleryIndexModel
            {
                 Images = imageList,
                 SearchQuery = ""
            };
            return View(model);
        }
    }

}
