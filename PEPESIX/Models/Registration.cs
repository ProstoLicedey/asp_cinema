using System.ComponentModel.DataAnnotations;

namespace pitpm_pr1.Models
{
    public class Registration
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя")]  //required - поле обязательное для зап.

        public string Name { get; set; } //получение и установление данных поля

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string Surame { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public string Age { get; set; }

        [Display(Name = "Введите телефон")]
        [Required(ErrorMessage = "Вам нужно ввести телефон")]
        [StringLength(10, ErrorMessage ="")]
        public string Phone { get; set; }

        [Display(Name = "Введите пароль")]
        [Required(ErrorMessage = "Вам нужно ввести пароль")]
        [StringLength(30, ErrorMessage = "Текст  менее 30 символов")]
        public string Password { get; set; }
    }
}

