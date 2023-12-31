﻿using System.ComponentModel.DataAnnotations;

namespace DZ_231123_Reviews_Repos_and_Sessions_.Models
{
    public class RegisterVM
    {
        [Required]
        [Display(Name = "Ім'я")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Прізвище")]
        public string? LastName { get; set; }

        [Required]
        [Display(Name = "Логін")]
        public string? Login { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [Display(Name = "Введіть пароль повторно")]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        [DataType(DataType.Password)]
        public string? PasswordConfirm { get; set; }
    }
}
