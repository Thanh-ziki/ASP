using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test01.Models
{
    [Table("Student")]
    public class Sutdent
    {
        [Key]
        public string HoVaTienSinhVien { get; set; }
        public string MaSinhVien { get; set; }
        public string KhoaHoc { get; set; }
        public string DangKyMonHoc { get; set; }
    }
}