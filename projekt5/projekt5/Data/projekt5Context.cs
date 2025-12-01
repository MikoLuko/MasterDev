using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using projekt5.Models;

namespace projekt5.Data
{
    public class projekt5Context : DbContext
    {
        public projekt5Context(DbContextOptions<projekt5Context> options) : base(options)
        { }
            public DbSet<Klient> klienci {  get; set; }
    }
}
