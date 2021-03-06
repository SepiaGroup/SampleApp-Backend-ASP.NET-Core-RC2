﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels.ManageViewModels
{
	public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
