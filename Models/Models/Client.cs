namespace VetClinic.Models
{
    /// <summary>
    /// Клиент.
    /// </summary>
    public class Client:Human
    {
        /// <summary>
        /// Список животных - пациентов.
        /// </summary>
        public List<Patient> Patients { get; set; }
    }
}
