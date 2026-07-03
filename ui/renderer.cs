using System;
using TaskManager.services;

namespace TaskManager;

public class Renderer
{
    public void Render(List<TaskItem> tasks, string msg)

    {   
        Console.Clear();
        Console.WriteLine(" Task Manager V1.0 ");
        Console.WriteLine("---------------------------------------");

        var counter = 0;

        foreach (var task in tasks)
        {
            var id = counter + 1;
            var title = task.Title;
            var isdone = task.IsDone;

            var mark = "-";
            if (isdone == true)
            {
                mark = "o" ;
            }  

            Console.WriteLine($" {id} | {mark} | {title}");    

            counter++ ; 
        }

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Commands :");
        Console.WriteLine("  add <title> ");
        Console.WriteLine("  toggle <id> ");
        Console.WriteLine("  delete <id> ");
        Console.WriteLine("  all");
        Console.WriteLine("  pending ");
        Console.WriteLine("  completed ");
        Console.WriteLine(msg);

        

    }
}
