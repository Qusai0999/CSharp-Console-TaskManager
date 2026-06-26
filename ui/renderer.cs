using System;

namespace TaskManager;

public class Renderer
{
    public void Render(List<TaskItem> tasks)
    {
        Console.WriteLine(" Task Manager V1.0 ");
        Console.WriteLine("---------------------------------------");

        foreach (var task in tasks)
        {
            var id = task.Id;
            var title = task.Title;
            var isdone = task.IsDone;

            var mark = "-";
            if (isdone == true)
            {
                mark = "o" ;
            }  

            Console.WriteLine($" {id} | {mark} | {title}");     
        }

        Console.WriteLine("---------------------------------------");
    }
}
