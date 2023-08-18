using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace Chat.ViewModel
{
    public class UploadViewModel
    {
        [Required]
        public int RoomId { get; set; }
        [Required]
        public IFormFile File { get; set; }
    }
}
