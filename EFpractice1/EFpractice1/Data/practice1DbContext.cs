using Microsoft.EntityFrameworkCore;

namespace EFpractice1.Data
{
    public class practice1DbContext : DbContext
    {

        public practice1DbContext(DbContextOptions<practice1DbContext> options)
            :base(options)
        {
                
        }
        DbSet<Empdetails> tblemployeeDetails { get; set; }
    }
}
