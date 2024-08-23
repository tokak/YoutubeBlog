﻿using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Entity.Entities
{
    //Makale Sınıfı
    public class Artice : EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}
