using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EFCoreBasics.Models;

namespace EFCoreBasics.Data
{
    public class EFCoreBasicsContext : DbContext
    {
        public EFCoreBasicsContext (DbContextOptions<EFCoreBasicsContext> options)
            : base(options)
        {
        }

        public DbSet<EFCoreBasics.Models.Student> Student { get; set; } = default!;
    }
}
