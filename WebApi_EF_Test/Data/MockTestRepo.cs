namespace WebApi_EF_Test.Data
{
    public class MockTestRepo : ITestRepo
    {
        public IEnumerable<TestModel> GetAllTestModels()
        {
            var testModels = new List<TestModel>
            {
                new TestModel{Id=0, TestString="Test String 0", TestOtherString="Other Test String 0", TestInt=100},
                new TestModel{Id=1, TestString="Test String 1", TestOtherString="Other Test String 1", TestInt=101},
                new TestModel{Id=2, TestString="Test String 2", TestOtherString="Other Test String 2", TestInt=102},
                new TestModel{Id=3, TestString="Test String 3", TestOtherString="Other Test String 3", TestInt=103},
                new TestModel{Id=4, TestString="Test String 4", TestOtherString="Other Test String 4", TestInt=104}
            }

            return testModels;
        }

        public TestModel GetTestModelByID(int inID)
        {
            return new TestModel{Id=0, TestString="Test String 0", TestOtherString="Other Test String 0", TestInt=100};
        }
    }
}