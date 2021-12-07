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

        [Required(ErrorMessage = "{0} Không Được Để Trống")]
        [Range(1, 20, ErrorMessage = "Số Lượng Người Phải Từ 1 - 20")]
        [Display(Name = "Số Lượng Người")]
        public int? ClientSlot { get; set; }
        [Required(ErrorMessage = "Phải Nhập Số Bàn")]
        [Range(1, 20, ErrorMessage = "Số Lượng Bàn Phải Từ 1 - 20")]

        [Display(Name = "Số Bàn")]
        public int? BookingSlot { get; set; }
        [Required(ErrorMessage = "Chi Nhánh Không Được Để Trống")]
        [Display(Name = "Chi Nhánh")]
        public string Branch { get; set; }

        [Required(ErrorMessage = "Phải nhập họ tên")]
        [Display(Name = "Họ Tên")]
        [MaxLength(50, ErrorMessage = "Tên Không Được Quá Dài")]
        public string UserName { get; set; }

        [Display(Name = "Số Điện Thoại")]
        [Required(ErrorMessage = "{0} Không Được Để Trống")]
        // [RegularExpression(@"^(\d{10})$", ErrorMessage = "Nhập Đúng Số Điện Thoại")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Nhập Đúng Số Điện Thoại")]
        public string UserPhone { get; set; }

        [Display(Name = "Ngày Tạo")]
        public DateTime CreateDate { get; set; }
    }
}