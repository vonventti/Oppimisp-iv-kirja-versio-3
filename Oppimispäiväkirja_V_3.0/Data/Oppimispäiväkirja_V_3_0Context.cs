using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oppimispäiväkirja_V_3._0.Models;

namespace Oppimispäiväkirja_V_3._0.Data
{
    public class Oppimispäiväkirja_V_3_0Context : DbContext
    {
        public Oppimispäiväkirja_V_3_0Context (DbContextOptions<Oppimispäiväkirja_V_3_0Context> options)
            : base(options)
        {
        }

        public DbSet<Oppimispäiväkirja_V_3._0.Models.Aihe> Aihe { get; set; }
    }
}
