﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic.DBModel
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=eUseControl")  {}

        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
