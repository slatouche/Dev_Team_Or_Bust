using System.Collections.Generic;
using WebApi_EF_Test.Data;
using WebApi_EF_Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_EF_Test.Controllers
{
    // api/TestModels
    // wildcard [controller] gets name from class name
    [Route("api/[controller]")]
    [ApiController]
    public class TestModelsController : ControllerBase
    {
        private readonly MockTestRepo _repository = new MockTestRepo();
        // GET api/TestModels
        [HttpGet]
        public ActionResult <IEnumerable<TestModel>> GetAllTestModels()
        {
            var testModelList = _repository.GetAllTestModels();
            return Ok(testModelList);
        }

        // GET api/TestModels/{id}
        [HttpGet("{id}")]
        public ActionResult <TestModel> GetTestModelByID(int inID)
        {
            var testModel = _repository.GetTestModelByID(inID);
            return Ok(testModel);
        }
    }
}