using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models.Branchs
{
    public class Branch
    {
        [Key]
        [Display(Name = "ID")]

        public int Id { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} Không Được Để Trống")]
        [Display(Name = "Tên Chi Nhánh")]
        public string BranchName { get; set; }

        [Display(Name = "Số Bàn Trống")]
        [Required(ErrorMessage = "{0} Không Được Để Trống")]
        [Range(1, 9999, ErrorMessage = "Phải Nhập Từ 0 - 9999")]
        public int? SlotTable { get; set; }


        [Required(ErrorMessage = "{0} Không Được Để Trống")]
        [Range(0, 3000, ErrorMessage = "Phải Nhập Từ 0 - 3000 Km")]
        [Display(Name = "Số Km")]
        public int? Distance { get; set; }

        [Required(ErrorMessage = "{0} Không Được Để Trống")]
        [StringLength(100)]
        [MaxLength(50, ErrorMessage = "{0} Không Được Quá Dài")]
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }
        [Display(Name = "Ngày Tạo")]
        public DateTime CreateDate { get; set; }
    }
}