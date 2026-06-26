using System;

namespace TaskManager 
{
    public class TaskItem
    {
        public int Id  {set; get;}
        public string? Title  {set; get;}
        public bool IsDone  {set; get;}

        public TaskItem(int id,string? title)
        {
            this.Id = id;
            this.Title = title;
            this.IsDone = false;
        }


    }
}