namespace YoutubeBlog.Web.ResultMessages
{
    public static class Messages
    {
        public static class Article
        {
            public static string Add(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla eklenmiştir";
            }
            public static string Update(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla güncellenmiştir";
            }

            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla silinmiştir";
            }
            public static string UndoDelete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla geri alınmıştır";
            }
        }

        public static class Category
        {
            public static string Add(string categoryTitle)
            {
                return $"{categoryTitle} başlıklı kategori başarıyla eklenmiştir";
            }
            public static string Update(string categoryTitle)
            {
                return $"{categoryTitle} başlıklı kategori başarıyla güncellenmiştir";
            }

            public static string Delete(string categoryTitle)
            {
                return $"{categoryTitle} başlıklı katogori başarıyla silinmiştir";
            }
            public static string UndoDelete(string categoryTitle)
            {
                return $"{categoryTitle} başlıklı katogori başarıyla geri alınmıştır.";
            }
        }

        public static class User
        {
            public static string Add(string userTitle)
            {
                return $"{userTitle} kullanıcısı başarıyla eklenmiştir";
            }
            public static string Update(string userTitle)
            {
                return $"{userTitle} kullanıcısı  başarıyla güncellenmiştir";
            }

            public static string Delete(string userTitle)
            {
                return $"{userTitle} kullanıcı kaydı başarıyla silinmiştir";
            }
        }



    }
}
