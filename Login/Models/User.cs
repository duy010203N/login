namespace Login.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public partial class User
    {
        [Key]
        [Column("User ID")]
        public int User_ID { get; set; }
        [StringLength(50)]
        public string ho { get; set; }
        [StringLength(50)]
        public string ten { get; set; }
        [StringLength(50)]
        public string email { get; set; }
        [StringLength(50)]
        public string password { get; set; }
        [StringLength(50)]
        public string phone { get; set; }
        [StringLength(200)]  // Đảm bảo chiều dài đủ để chứa chuỗi Base-64
        public string avatar { get; set; }
    }
}