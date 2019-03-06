using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp2.Models.Addresses;
using WebApp2.Models.Account;

namespace WebApp2.DataConnections
{
    public class UserAccountDB : DbContext
    {
        public UserAccountDB() : base("WebApp2")
        { }

        public DbSet<UserAccount> UserDetails { get; set; }

    }
}