using Microsoft.EntityFrameworkCore;
using WebApi_EF_Test.Models;

namespace WebApi_EF_Test.Data
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> opt) : base(opt)
        {
            
        }

        public DbSet<TestModel> TestModels { get; set; }

    }
}