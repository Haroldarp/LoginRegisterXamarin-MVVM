﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoginRegisterXamarin.MVVM.Models
{
    class SingUpUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public SingUpUser()
        {
        }

    }
}
