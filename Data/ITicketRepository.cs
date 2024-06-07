using HelpdeskTicketSupportApp.Models;

namespace HelpdeskTicketSupportApp.Data
{   /// <summary>
    /// Schnitstelle für das Ticket Repository. 
    /// </summary>
    public interface ITicketRepository
    {   /// <summary>
    /// Bringt alle die Tickets
    /// </summary>
    
        Task<IEnumerable<Ticket>> GetAllTicketsAsync();

        /// <summary>
        /// Bringt eine vorhandene Ticket nachID
        /// </summary>
        /// <param name="id">ID</param>
        
        Task<Ticket> GetTicketByIdAsync(int id);

        /// <summary>
        /// Erstellt eine neue Ticket
        /// </summary>
        /// <param name="ticket">Name</param>
        
        Task CreateTicketAsync(Ticket ticket);

        /// <summary>
        /// Aktualisiert ein vorhandenes Ticket Asyncron
        /// </summary>
       
        Task UpdateTicketAsync(Ticket ticket);

        /// <summary>
        /// Löscht Eine Vorhandene Ticket nach Id
        /// </summary>
        /// <param name="id">ID</param>
        
        Task DeleteTicketAsync(int id);
    }
}
