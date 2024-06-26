﻿using System.Collections.Generic;

namespace Dk.BankApp.Web.Data.Entities
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
