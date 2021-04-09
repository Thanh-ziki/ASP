using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL._1.Models
{
    [Table("QuanLyThuViens")]
    public class QuanLyThuVien
    {
        [Key]
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaLoaiSach { get; set; }
        public string SoLuong { get; set; }
    }
}