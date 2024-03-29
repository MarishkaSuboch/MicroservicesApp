﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ordering.Core.Entities;

namespace Ordering.Infrastructure.Data
{
    public class OrderContext:DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            :base(options)
        {
            
        }

        public DbSet<Order> Orders { get; set; }
    }
}
