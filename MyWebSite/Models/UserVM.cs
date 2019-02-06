using MyWebSite.DAL.MyEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWebSite.Models
{
    public class UserVM
    {
        public int UserId { get; set; }

        [Required(ErrorMessage ="boş geçme")]
        [MaxLength(20,ErrorMessage ="max 20 karakter olmalı")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "boş geçme")]
        [MaxLength(20, ErrorMessage = "max 20 karakter olmalı")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "boş geçme")]
        [MaxLength(50, ErrorMessage = "max 50 karakter olmalı")]
        [EmailAddress(ErrorMessage ="mail formatında giriş yap")]

        public string EMail { get; set; }

        [Required(ErrorMessage = "boş geçme")]

        public string Password { get; set; }

        [Required(ErrorMessage = "boş geçme")]

        public bool Gender { get; set; }
    }
}