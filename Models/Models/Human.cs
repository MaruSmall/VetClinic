using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace VetClinic.Models
{
    /// <summary>
    /// Человек.
    /// </summary>
    public class Human
    {
        /// <summary>
        /// Индетификатор.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Отчество.
        /// </summary>
        public string? Patronumic { get; set; }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Паспортные данные.
        /// </summary>
        public string PassportData { get; set; }

    }
}
