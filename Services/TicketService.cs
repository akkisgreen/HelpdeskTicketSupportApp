using HelpdeskTicketSupportApp.Data;
using HelpdeskTicketSupportApp.Models;

namespace HelpdeskTicketSupportApp.Services
{   /// <summary>
    /// Dienst für die Verarbeitung von Ticketgeschäftslogik.
    /// </summary>
    public class TicketService
    {
        private readonly ITicketRepository _ticketRepository;

        /// <summary>
        /// Konstruktor für den TicketService.
        /// </summary>
        /// <param name="ticketRepository">Ticket-Repository-Instanz.</param>

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        /// <summary>
        /// Gibts Alle Tickets zurück.
        /// </summary>
        /// <returns>await ticketrepository.GetallTicketsAsync</returns>

        public async Task<IEnumerable<Ticket>> GetAllTicketsAsync()
        {
            return await _ticketRepository.GetAllTicketsAsync();
        }

        /// <summary>
        /// Gibt ein Ticket nach ID zurück.
        /// </summary>
        /// <param name="id">int Id</param>
        /// <returns>GetTicketbyIdAsync</returns>
        public async Task<Ticket> GetTicketByIdAsync(int id)
        {
            return await _ticketRepository.GetTicketByIdAsync(id);
        }

        /// <summary>
        /// erstell ein neues Ticket 
        /// </summary>
        /// <param name="ticket">Ticket</param>
        /// <returns>CreateTicketAsync</returns>

        public async Task CreateTicketAsync(Ticket ticket)
        {
            await _ticketRepository.CreateTicketAsync(ticket);
        }

        /// <summary>
        /// aktualisiert ein vorhandenes Ticket
        /// </summary>
        /// <param name="ticket">ticket</param>
        /// <returns>UpdateTicketAsync</returns>

        public async Task UpdateTicketAsync(Ticket ticket)
        {
            await _ticketRepository.UpdateTicketAsync(ticket);
        }

        /// <summary>
        /// Löscht Ein Ticket nach ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>DeleteTicketAsync</returns>

        public async Task DeleteTicketAsync(int id)
        {
            await _ticketRepository.DeleteTicketAsync(id);
        }
    }
}
