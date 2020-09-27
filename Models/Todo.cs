using System;
using System.ComponentModel.DataAnnotations;

namespace DJBlogToDo.Models
{
    public class Todo
    {
        public Todo()
        {
            this.Status = "Active";
        }
        public int ID { get; set; }
        public string Description { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }
        //Completed
        //Active
        //Pending
        public string Status { get; set; }
    }
}