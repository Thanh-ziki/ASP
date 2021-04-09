using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_SQL.Models
{
    [Table("NotDay")]
    public class NotDay
    {
        [Key]
        public string NhatKySo { get; set; }
        public string NoiDung { get; set; }
    }
}