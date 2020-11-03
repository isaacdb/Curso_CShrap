﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Enum.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BithDate { get; set; }

        public Client(string name, string email, DateTime bithDate)
        {
            Name = name;
            Email = email;
            BithDate = bithDate;
        }
        public override string ToString()
        {
            return Name + " (" + BithDate + ") - " + Email;
        }
    }
}
