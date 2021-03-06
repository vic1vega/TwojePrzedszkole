using System;

namespace TwojePrzedszkole.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public PhotoGallery PhotoGallery { get; set; }
        public int PhotoGalleryId { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
    }
}