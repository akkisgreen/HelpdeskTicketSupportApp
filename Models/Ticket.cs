namespace HelpdeskTicketSupportApp.Models
{   
    /// <summary>
    /// Represäntiert ein Ticket
    /// </summary>
    public class Ticket
    {   /// <summary>
        /// Ticket ÍD
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Titel Des Tickets
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Beschreibung Des Ticket (inhalt Den Ticket)
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// status des Tickets
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Erstell Datum des Tickets
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Letzte Aktualizierung Datum Des Tickets
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}
