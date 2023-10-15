namespace Ket_noi_database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [StringLength(10)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(250)]
        public string ProductName { get; set; }

        public int Price { get; set; }

        public int CategoryID { get; set; }

        public virtual Categorys Categorys { get; set; }
       
    }
}
