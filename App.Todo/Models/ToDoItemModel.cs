using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App.Todo.Models
{
    public class ToDoItemModel
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Column(TypeName = "nvarchar(100)")]
        public string description { get; set; }

        [Required(ErrorMessage = "ItemStatus is required")]
        [Column(TypeName = "nvarchar(100)")]
        public string status { get; set; }
    }
}
