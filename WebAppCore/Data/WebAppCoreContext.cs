using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppCore.Models;

namespace WebAppCore.Data
{
    public class WebAppCoreContext : DbContext
    {
        public WebAppCoreContext (DbContextOptions<WebAppCoreContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCore.Models.Student>? Student { get; set; }
    }
}
