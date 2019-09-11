using System.Collections.ObjectModel;

namespace TwojePrzedszkole.API.Models
{
    public class PhotoGallery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Collection<Photo> Photos { get; set; }
    }
}