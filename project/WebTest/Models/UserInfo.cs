using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Models
{
   [Table("UserInfo")]
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [MaxLength(50), Required]
        public string UserName { get; set; }
        [Required]
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
    
}
