namespace Test01.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Accounts
    {
        [Key]
        public string UserName { get; set; }

        public string PassWord { get; set; }

        public string Address { get; set; }
    }
}
