using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bai3.Models
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHH { get; set; }
        [Required]
        [MaxLength(100)]
        public string? TenHH { get; set; }
        public string? MoTa { get; set; }
        public double DonGia { get; set; }
        public byte GiamGia { get; set; }
        public int? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai? Loai { get; set; }
    }
}
