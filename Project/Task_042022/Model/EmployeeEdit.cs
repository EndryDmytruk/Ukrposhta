using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Task_042022.Model
{
    public class EmployeeEdit
    {
        [Required(ErrorMessage = "Поле код є обов'язковим!")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Максимальна довжина поля 20 символів мінімальна 1!")]
        public string Code { get; set; }


        [Required(ErrorMessage = "Поле ім'я є обов'язковим!")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Максимальна довжина поля 20 символів мінімальна 1!")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Поле прізвище є обов'язковим!")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Максимальна довжина поля 20 символів мінімальна 1!")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Поле по батькові є обов'язковим!")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Максимальна довжина поля 20 символів мінімальна 1!")]
        public string Lastname { get; set; }


        [Required(ErrorMessage = "Поле телефон є обов'язковим!")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Поле адреса є обов'язковим!")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Максимальна довжина поля 20 символів мінімальна 1!")]
        public string Address { get; set; }

        public string Department { get; set; }

        public string Position { get; set; }

        [Required(ErrorMessage = "Поле оклад є обов'язковим!")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Максимальна довжина поля 10 символів мінімальна 1!")]
        [RegularExpression(@"^[0-9]+$|^[0-9]+.[0-9]{2}$|^[0-9]+,[0-9]{2}$", ErrorMessage = "Некорректный адрес")]
        public string Salary { get; set; }

        public string Premium { get; set; }

    }
}
