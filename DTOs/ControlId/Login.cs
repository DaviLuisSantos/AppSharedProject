using System;
using System.Collections.Generic;
using System.Text;

namespace AppSharedProject.DTO.ControlId
{
    class Login(string login, string password)
    {
        public string login { get; set; } = login;
        public string password { get; set; } = password;
    }
}
