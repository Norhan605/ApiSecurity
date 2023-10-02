using System;
using System.Collections.Generic;

namespace APISecurity.Models
{
    public class AuthModel
    {
        public string Username { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public List<string> Roles { get; set; }
        public bool IsAuthenticated { get; set; }
        public DateTime ExpiresOn { get; set; }


    }
}
