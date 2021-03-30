using System.Collections.Generic;
using WebApi_EF_Test.Models;

namespace WebApi_EF_Test.Data
{
    public interface ITestRepo
    {
        IEnumerable<TestModel> GetAllTestModels();
        TestModel GetTestModelByID(int inID);
    }
}