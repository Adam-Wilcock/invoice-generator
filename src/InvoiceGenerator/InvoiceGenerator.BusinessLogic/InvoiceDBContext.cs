﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.BusinessLogic
{
    public class InvoiceDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:invoice-generator.database.windows.net,1433;Initial Catalog=invoice-generator;Persist Security Info=False;User ID=ef-user;Password=x3Dh0zfg2s1k;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<Client> Clients { get; set; }
    }
}
