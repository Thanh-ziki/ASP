using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_SQL.Models
{
    [Table("ShopPets")]
    public class ShopPet
    {
        [Key]
        public string IDPet { get; set; }
        public string TenPet { get; set; }
        public string LoaiPet { get; set; }
        public string TuoiCuaPet { get; set; }

    }
}