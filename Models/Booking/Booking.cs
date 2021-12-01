using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models.Bookings
{
    public class Booking
    {
        [Key]
        [Display(Name = "ID")]

        public int Id { get; set; }

        [Column(TypeName = "int")]

        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Số Lượng Người")]
        public int ClientSlot { get; set; }
        [Required(ErrorMessage = "Phải nhập số bàn")]
        [Display(Name = "Số Bàn")]
        public int BookingSlot { get; set; }
        [Required(ErrorMessage = "Phải nhập chi nhánh")]
        [Display(Name = "Chi Nhánh")]
        public string Branch { get; set; }

        [Required(ErrorMessage = "Phải nhập họ tên")]
        [Display(Name = "Họ Tên")]
        public string UserName { get; set; }

        [Display(Name = "Số Điện Thoại")]
        public string UserPhone { get; set; }

        [Display(Name = "Ngày Tạo")]
        public DateTime CreateDate { get; set; }
    }
}