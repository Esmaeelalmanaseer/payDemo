using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace payDemo.Models
{
    public class Paydetals
    {
        [Key]
        public int PayId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CardOwner { get; set; }
        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        public string ExpirPay { get; set; }
        [Column(TypeName ="nvarchar(3)")]
        public string securityCode { get; set; }
    }
}
