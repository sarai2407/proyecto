using FullStackAPI.models;
using Microsoft.EntityFrameworkCore;

namespace FullStackAPI.data
{
    public class FullStackDbContex : DbContext
    {
        public FullStackDbContex(DbContextOptions options) : base(options) 
        { 
            
        }

        public DbSet<empleado> empleados { get; set; }
    }
}
