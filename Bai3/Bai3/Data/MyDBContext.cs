using Bai3.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai3.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions option) : base(option) { }

        #region  Dbset
        public DbSet<HangHoa> hangHoas { get; set; }
        public DbSet<Loai> Loais { get; set; }

        #endregion
    }
}
