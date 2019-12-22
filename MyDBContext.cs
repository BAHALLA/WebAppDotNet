using Microsoft.EntityFrameworkCore;
using WebAppDotNet.Model;

namespace WebAppDotNet{

    public class MyDBContext: DbContext {

        public DbSet<Student> Students{ get; set;}
        public MyDBContext(DbContextOptions options): base(options) {}
    }
}