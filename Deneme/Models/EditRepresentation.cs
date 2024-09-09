using DocumentFormat.OpenXml.Wordprocessing;

namespace Deneme.Models
{
    public class EditRepresentation
    {
        public string nameSurname { get; set; }
        public string title { get; set; }
        public IFormFile image { get; set; }
    }
}
