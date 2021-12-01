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
        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Tên Chi Nhánh")]
        public string BranchName { get; set; }
        [Required(ErrorMessage = "Phải nhập bàn trống")]
        [Display(Name = "Số Bàn Trống")]
        public int SlotTable { get; set; }
        [Required(ErrorMessage = "Phải nhập số km")]
        [Display(Name = "Số Km")]
        public int Distance { get; set; }
        [Required(ErrorMessage = "Phải nhập địa chỉ")]
        [StringLength(100)]
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }
        [Display(Name = "Ngày Tạo")]
        public DateTime CreateDate { get; set; }
    }
}