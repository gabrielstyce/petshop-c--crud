﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.MODEL
{
    public class Cliente : Pessoa
    {
        private string email;

        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return Email + Codigo.ToString();
        }
    }
}
