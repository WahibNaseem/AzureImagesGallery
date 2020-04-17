using AzureImagesGallery.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureImagesGallery.Controllers
{
    public class GalleryController:Controller
    {
        public GalleryController()
        {

        }

        public IActionResult Index()
        {
            var model = new GalleryIndexModel
            {

            };
            return View();
        }
    }

}
