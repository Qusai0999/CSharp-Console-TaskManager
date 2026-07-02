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
            var msg = " ";
            var active = true;
                // Console.Clear();
            engine.Render( taskservice.GetAllTasks() ,msg);
            
            while (active)
            {

                Console.Write(">>");
                string? input = Console.ReadLine();

                (string? command, string? payload) = CommandService.Parse(input);   // warning : Ignore
                
                switch (command)
                {
                    case "add": {
                            if (string.IsNullOrEmpty(payload)){return;}
                            taskservice.AddTask(payload);

                            Console.Clear();
                            engine.Render( taskservice.GetAllTasks() ,msg);

                            Console.WriteLine("task added !");
                            
                            break;
                    }
                    case "delete": {
                            if (string.IsNullOrEmpty(payload)){return;}
                            try
                            {
                                int id = Convert.ToInt32(payload);
                                if (taskservice.DeleteTask(id) == -1)
                                {
                                    System.Console.WriteLine($"No Task With ID {id} Found !");
                                    break; 
                                }
                                
                                
                                Console.Clear();
                                engine.Render( taskservice.GetAllTasks() ,msg);
                            
                                Console.WriteLine("task deleted !");

                            }
                            catch (System.Exception e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                            break;
                    }
                    case "toggle":
                        {
                            if (string.IsNullOrEmpty(payload)){return;}
                            try
                            {
                                int id = Convert.ToInt32(payload);
                                Console.WriteLine(id);
                                if (taskservice.ToggleTask(id) == -1)
                                {
                                    System.Console.WriteLine($"No Task With ID {id} Found !");
                                    break;
                                }
                                
                                Console.Clear();
                                engine.Render( taskservice.GetAllTasks() ,msg);
                            
                                Console.WriteLine("task Updated !");

                            }
                            catch (System.Exception e)
                            {
                                Console.WriteLine(e.ToString());
                            }
                            break;
                        }
                    case "all": {
                        
                        Console.Clear();
                        engine.Render( taskservice.GetAllTasks() ,msg);
                            
                        break;
                    }
                    case "pendding": {
                        
                        Console.Clear();
                        engine.Render( taskservice.GetPendingTasks() ,msg);
                            
                        break;
                    }
                    case "completed": {
                        
                        Console.Clear();
                        engine.Render( taskservice.GetCompletedTasks() ,msg);
                            
                        break;
                    }
                    case "exit": {
                        active = false;
                        break;
                    }
                    default:
                        {
                            System.Console.WriteLine("please enter a valid command !");
                            break;
                        }
                }


            }

        }
    }
}