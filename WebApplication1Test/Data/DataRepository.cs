using WebApplication1Test.Models;
using TaskModel = WebApplication1Test.Models.Task; 

namespace WebApplication1Test.Data
{
    public class DataRepository
    {
        private readonly Dictionary<int, Master> _masters = new Dictionary<int, Master>();
        private readonly Dictionary<int, TaskModel> _tasks = new Dictionary<int, TaskModel>();
        private int _nextMasterId = 1;
        private int _nextTaskId = 1;

        public IEnumerable<Master> GetAllMasters()
        {
            return _masters.Values;
        }

        public Master GetMasterById(int id)
        {
            return _masters.ContainsKey(id) ? _masters[id] : null;
        }

        public Master AddMaster(Master master)
        {
            master.Id = _nextMasterId++;
            _masters.Add(master.Id, master);
            return master;
        }

        public IEnumerable<TaskModel> GetAllTasks() 
        {
            return _tasks.Values;
        }

        public TaskModel GetTaskById(int id) 
        {
            return _tasks.ContainsKey(id) ? _tasks[id] : null;
        }

        public TaskModel AddTask(TaskModel task) 
        {
            task.Id = _nextTaskId++;
            _tasks.Add(task.Id, task);
            return task;
        }
    }
}
