using System.Collections.Generic;
using System.Linq;
using WebApi_EF_Test.Models;

namespace WebApi_EF_Test.Data
{
    public class SqlTestRepo : ITestRepo
    {
        
        private readonly TestDBContext _context;

        public SqlTestRepo(TestDBContext inContext)
        {
            _context = inContext;
        }

        public IEnumerable<TestModel> GetAllTestModels()
        {
            return _context.TestModels.ToList();
        }

        public TestModel GetTestModelByID(int inID)
        {
            return _context.TestModels.FirstOrDefault(p => p.Id == inID);
        }
    }
}