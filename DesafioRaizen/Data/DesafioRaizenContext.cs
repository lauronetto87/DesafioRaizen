using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DesafioRaizen.Models;

namespace DesafioRaizen.Data
{
    public class DesafioRaizenContext : DbContext
    {
        public DesafioRaizenContext (DbContextOptions<DesafioRaizenContext> options)
            : base(options)
        {
        }

        public DbSet<DesafioRaizen.Models.Cliente> Cliente { get; set; } = default!;
    }
}
