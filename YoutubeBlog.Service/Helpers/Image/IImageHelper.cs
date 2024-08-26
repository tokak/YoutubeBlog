using Microsoft.AspNetCore.Http;
using YoutubeBlog.Entity.DTOs.Images;
using YoutubeBlog.Entity.Enums;

namespace YoutubeBlog.Service.Helpers.Image
{
    public interface IImageHelper
    {
        
        Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, ImageType imageType, string foldername = null);
        void Delete(string imageName);
    }
}
