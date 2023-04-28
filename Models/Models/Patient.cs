namespace VetClinic.Models
{
    /// <summary>
    /// Животное пациент.
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Индетификатор.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя(Кличка).
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Возвраст.
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Пол.
        /// </summary>
        public bool Sex { get; set; }
        
        /// <summary>
        /// Порода.
        /// </summary>
        public string Breed { get; set; }
        
        /// <summary>
        /// Вид.
        /// </summary>
        public string View { get; set; }
        
        /// <summary>
        /// Шерсть.
        /// </summary>
        public string Wool { get; set; }

    }
}
