using System.Collections.Generic;
using WebApi_EF_Test.Data;
using WebApi_EF_Test.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using WebApi_EF_Test.DTOs;

namespace WebApi_EF_Test.Controllers
{
    // api/TestModels
    // wildcard [controller] gets name from class name
    [Route("api/[controller]")]
    [ApiController]
    public class TestModelsController : ControllerBase
    {
        private readonly ITestRepo _repo;
        private readonly IMapper _mapper;

        public TestModelsController(ITestRepo inRepo, IMapper mapper)
        {
            _repo = inRepo;
            _mapper = mapper;
        }
        
        //private readonly MockTestRepo _repo = new MockTestRepo();
        // GET api/TestModels
        [HttpGet]
        public ActionResult<IEnumerable<TestModelReadDTO>> GetAllTestModels()
        {
            var testModelList = _repo.GetAllTestModels();
            return Ok(_mapper.Map<IEnumerable<TestModelReadDTO>>(testModelList));
        }

        // GET api/TestModels/{id}
        [HttpGet("{inID}", Name="GetTestModelByID")]
        public ActionResult<TestModelReadDTO> GetTestModelByID(int inID)
        {
            var testModel = _repo.GetTestModelByID(inID);
            
            if(testModel != null)
            {
                return Ok(_mapper.Map<TestModelReadDTO>(testModel)); 
            }

            return NotFound();
        }

        // POST api/TestModels
        [HttpPost]
        public ActionResult<TestModelReadDTO> CreateTestModel(TestModelCreateDTO inTestModelCreateDTO)
        {
            var testModel = _mapper.Map<TestModel>(inTestModelCreateDTO);
            _repo.CreateTestModel(testModel);
            _repo.SaveChanges();

            var testModelReadDTO = _mapper.Map<TestModelReadDTO>(testModel);

            return CreatedAtRoute(nameof(GetTestModelByID), new {inID = testModelReadDTO.Id}, testModelReadDTO);
        }
    }
}