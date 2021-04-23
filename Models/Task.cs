using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApi.Models
{
   public class Task
   {
      public enum Priorities
      {
         Low,
         Medium,
         High
      }
      public int Id { get; set; }
      public string Title { get; set; }
      public string Description { get; set; }
      public string Image { get; set; }
      public DateTime Date { get; set; }
      public Priorities Priority { get; set; }

      public Task(int id, string title, string description, string image, DateTime date, Priorities priority)
      {
         Id = id;
         Title = title;
         Description = description;
         Image = image;
         Date = date;
         Priority = priority;
      }
   }


}