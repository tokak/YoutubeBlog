﻿using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Entity.Entities
{
    //Makale Sınıfı
    public class Article : EntityBase
    {
        //public Article()
        //{
            
        //}
        //public Article(string title,string content,Guid userId,Guid categoryId,Guid imageId)
        //{
        //    Title = title;
        //    Content = content;
        //    UserId = userId;
        //    CategoryId = categoryId;
        //    ImageId = imageId;

        //}
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; } = 0;

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid? ImageId { get; set; }
        public Image Image { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
