using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.DAL.Models
{
    public class Department
    {
        public int Id {  get; set; }
        [Required(ErrorMessage ="Code is Required!")]
        public string Code { get; set; } // .Net 5.0 Allow Null
        [Required(ErrorMessage = "Name is Required!")]

        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
