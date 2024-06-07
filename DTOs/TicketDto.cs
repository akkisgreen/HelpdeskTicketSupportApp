namespace HelpdeskTicketSupportApp.DTOs
{   /// <summary>
    /// DTO (Data Transfer Objekt) ist eine objekt für Daten trensfer inzwischen DB .
    /// </summary>
    public class TicketDto
    {   /// <summary>
        /// Ticket Objekt fur Daten Transfer, ID von TicketObjekt
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Title des Ticket Objekts
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Erklärung bereich des Ticket Objekts
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Status des Ticket Objekts
        /// </summary>
        public string Status { get; set; } = string.Empty;
    }
}
