namespace VetClinic.Models
{
    /// <summary>
    /// Врач.
    /// </summary>
    public class Doctor:Employee
    {
        /// <summary>
        /// Специальность.
        /// </summary>
        public string Speciality { get; set; }

        /// <summary>
        /// Кабинет.
        /// </summary>
        public string Cabinet { get; set; }

    }
}
