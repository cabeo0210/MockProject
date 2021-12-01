using System;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Agency
    {
        [Key]
        public int Id { set; get; }

        [StringLength(30)]
        [Required]
        public string Name { set; get; }
        [Required]
        public string Address { set; get; }
        [Required]
        public int Slot { set; get; }
        [Required]

        public double Instance { set; get; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime CreateDate { set; get; }
    }
}