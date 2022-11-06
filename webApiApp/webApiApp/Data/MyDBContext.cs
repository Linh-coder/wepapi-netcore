using Microsoft.EntityFrameworkCore;

namespace webApiApp.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        {

        }

        #region DBSet

        public DbSet<HangHoa> HangHoas { get; set; }

        public DbSet<Loai> Loais { get; set; }

        #endregion
    }
}
