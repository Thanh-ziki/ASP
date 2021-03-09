

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTQL.Models
{
   [Table("students")]
    public class student
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string address { get; set; }
        public string QueQuan { get; set; }
    }
}