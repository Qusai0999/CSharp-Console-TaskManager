using System;

namespace TaskManager.services
{
    public class TaskService
    /* Responsible of Creating and Managing Tasks  */
    {
        private List<TaskItem> _tasks ;

        public List<TaskItem> TasksList {get=> _tasks;}

        public TaskService()
        {
            _tasks = new List<TaskItem>();
        }
        
        public void AddTask(string? title)
        {
            if (string.IsNullOrEmpty(title)) return ;

            int next_id = _tasks.Count;

            var taskitem = new TaskItem(next_id,title);
            _tasks.Add(taskitem);

        }

        public int DeleteTask(int id)
        {
            var task = _tasks.ElementAtOrDefault(id);
            if (task != null)
            {
                _tasks.Remove(task);
                return 0;
            }
            return -1;
        }

        public int ToggleTask(int id)
        {
            var task = _tasks.ElementAtOrDefault(id);
            if (task != null)
            {
                task.IsDone = !task.IsDone ;
                return 0;
            }
            return -1;
        }

        public TaskItem GetTask(int id)
        {
            if (_tasks[id] == null)
            {
                throw new Exception($"No Task With Id {id} ");
            }
            return _tasks[id];
        }

        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }

        public List<TaskItem> GetCompletedTasks()
        {
            var completed = _tasks
                            .Where(task => task.IsDone == true)
                            .ToList(); 
            return completed;
        }

        public List<TaskItem> GetPendingTasks()
        {
            var pending = _tasks
                            .Where(task => task.IsDone == false)
                            .ToList(); 
            return pending;
        }

    }

}