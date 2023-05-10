using Microsoft.EntityFrameworkCore;

namespace BackEnd_Task.DataAccessLayer
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
    }
}
