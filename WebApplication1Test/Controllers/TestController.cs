using Microsoft.AspNetCore.Mvc;
using WebApplication1Test.Data;
using WebApplication1Test.Models;

namespace WebApplication1Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly DataRepository _repository;

        public TestController(DataRepository repository)
        {
            _repository = repository;
        }

        // GET: api/test/Masters
        [HttpGet("Masters")]
        public IActionResult GetMasters()
        {
            var masters = _repository.GetAllMasters();
            return Ok(masters);
        }

        // POST: api/test/AddMaster
        [HttpPost("AddMaster")]
        public IActionResult AddMaster([FromBody] Master master)
        {
            if (master == null)
                return BadRequest();

            var addedMaster = _repository.AddMaster(master);
            return CreatedAtAction(nameof(GetMasterById), new { id = addedMaster.Id }, addedMaster);
        }

        // GET: api/test/GetMasterById/5
        [HttpGet("GetMasterById/{id}")]
        public IActionResult GetMasterById(int id)
        {
            var master = _repository.GetMasterById(id);
            if (master == null)
                return NotFound();

            return Ok(master);
        }

        // GET: api/test/Tasks
        [HttpGet("Tasks")]
        public IActionResult GetTasks()
        {
            var tasks = _repository.GetAllTasks();
            return Ok(tasks);
        }

        // POST: api/test/AddTask
        [HttpPost("AddTask")]
        public IActionResult AddTask([FromBody] Models.Task task)
        {
            if (task == null)
                return BadRequest();

            if (!ModelState.IsValid) // Проверка на валидность модели
                return BadRequest(ModelState);

            var addedTask = _repository.AddTask(task);
            return CreatedAtAction(nameof(GetTaskById), new { id = addedTask.Id }, addedTask);
        }

        // GET: api/test/GetTaskById/5
        [HttpGet("GetTaskById/{id}")]
        public IActionResult GetTaskById(int id)
        {
            var task = _repository.GetTaskById(id);
            if (task == null)
                return NotFound();

            return Ok(task);
        }
    }

}