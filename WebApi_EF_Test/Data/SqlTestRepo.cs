using System;
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

        public void CreateTestModel(TestModel inTestModel)
        {
            if(inTestModel == null)
            {
                throw new ArgumentNullException(nameof(inTestModel));
            }

            _context.TestModels.Add(inTestModel);
        }

        public IEnumerable<TestModel> GetAllTestModels()
        {
            return _context.TestModels.ToList();
        }

        public TestModel GetTestModelByID(int inID)
        {
            return _context.TestModels.FirstOrDefault(p => p.Id == inID);
        }

        public bool SaveChanges()
        {
            return(_context.SaveChanges() >= 0);
        }
    }
}