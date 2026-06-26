using System;

namespace TaskManager
{
    public static class Program
    {
        public static void Main()
        {
            var taskslist = new List<TaskItem>
            {
                new TaskItem(1,"one"),
                new TaskItem(2,"two"),
                new TaskItem(3,"three")
            };
            var engine = new Renderer();

            engine.Render(taskslist);




            Console.ReadKey();
        }
    }
}