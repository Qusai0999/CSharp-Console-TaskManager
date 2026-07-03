using System;

namespace TaskManager 
{
    public class TaskItem
    {
        public string? Title  {set; get;}
        public bool IsDone  {set; get;}

        public TaskItem(int id,string? title)
        {
            this.Title = title;
            this.IsDone = false;
        }


    }
}