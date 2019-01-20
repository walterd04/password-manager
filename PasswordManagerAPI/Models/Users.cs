﻿using System;
using System.Collections.Generic;

namespace PasswordManagerAPI.Models
{
    public partial class Users
    {
        public Users()
        {
            PasswordManager = new HashSet<PasswordManager>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public DateTime? SignUpDate { get; set; }

        public ICollection<PasswordManager> PasswordManager { get; set; }
    }
}
