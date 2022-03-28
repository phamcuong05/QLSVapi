using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string code { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string name { get; set; }
        
        public int age { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string gender { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string email { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string address { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string specialist { get; set; }
    }
}
