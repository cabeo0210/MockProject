// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Areas.Identity.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "You need input {0}")]
        [EmailAddress(ErrorMessage = "Sai định dạng Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "You need input {0}")]
        [StringLength(100, ErrorMessage = "{0} phải dài từ {2} đến {1} ký tự.", MinimumLength = 2)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Re-password")]
        [Compare("Password", ErrorMessage = "Mật khẩu lặp lại không chính xác.")]
        public string ConfirmPassword { get; set; }


        [DataType(DataType.Text)]
        [Display(Name = "Account")]
        [Required(ErrorMessage = "You need input {0}")]
        [StringLength(100, ErrorMessage = "{0} phải dài từ {2} đến {1} ký tự.", MinimumLength = 3)]
        public string UserName { get; set; }

    }
}
