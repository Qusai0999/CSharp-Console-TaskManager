using System;
using TaskManager.services;

namespace TaskManager
{
    public static class Program
    {
        public static void Main()
        {

            var engine = new Renderer();

            var taskservice = new TaskService();
            taskservice.AddTask("one");

            taskservice.AddTask("two");
            taskservice.AddTask("three");
            taskservice.AddTask("four");
            // Console.WriteLine(taskservice.TasksList.Count);

            engine.Render(taskservice.TasksList);
            Console.WriteLine(taskservice.GetAllTasks().Count);
            Console.ReadKey();

            taskservice.ToggleTask(0);
            taskservice.ToggleTask(1); 

            engine.Render(taskservice.TasksList);
            Console.WriteLine(taskservice.GetCompletedTasks().Count);
            Console.WriteLine(taskservice.GetPendingTasks().Count);
            Console.ReadKey();


            engine.Render(taskservice.TasksList);
            Console.WriteLine(taskservice.GetTask(1).Title);
            Console.WriteLine(taskservice.GetTask(2).Title);
            Console.ReadKey();

            taskservice.DeleteTask(3);
            taskservice.DeleteTask(2);

            engine.Render(taskservice.TasksList);
            Console.ReadKey();
        }
    }
}