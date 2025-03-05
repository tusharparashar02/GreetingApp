﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Context
{
    public class UserContext : DbContext
    {
        public virtual DbSet<Entity.UserEntity> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
    }
}
