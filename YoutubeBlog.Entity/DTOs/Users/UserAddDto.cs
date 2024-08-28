﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Entity.DTOs.Users
{
    public class UserAddDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        //seçilecek rolün Id alma
        public Guid RoleId { get; set; }
        //Rollerin Listesini almak
        public List<AppRole> Roles { get; set; }
    }
}
