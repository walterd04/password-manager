using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordManager.Core.Entities
{
    public class PasswordManager
    {
        public int PasswordId { get; set; }
        public int UserId { get; set; }
        public string Engine { get; set; }
        public string Password { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public Users User { get; set; }
    }
}
