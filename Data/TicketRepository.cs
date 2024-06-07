using HelpdeskTicketSupportApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpdeskTicketSupportApp.Data
{   /// <summary>
/// Repository fur zugriff den Ticketdaten.
/// </summary>
    public class TicketRepository : ITicketRepository
    {  
        private readonly AppDbContext _context;

        /// <summary>
        /// Kontruktor für Ticketrepository.
        /// </summary>
        /// <param name="context">Datenbankkontext</param>
        public TicketRepository(AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Gibt Alle Tickets zuruck.
        /// </summary>
        /// <returns></returns>

        public async Task<IEnumerable<Ticket>> GetAllTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }

        /// <summary>
        /// Gibts ein ticked mit ID zurück.
        /// </summary>
     

        public async Task<Ticket> GetTicketByIdAsync(int id)
        {
            return await _context.Tickets.FindAsync(id) ?? throw new InvalidOperationException("Ticket nicht gefunden!");
        }

        /// <summary>
        /// Erstellt neue Ticket
        /// </summary>
      
        public async Task CreateTicketAsync(Ticket ticket)
        {
            await _context.Tickets.AddAsync(ticket);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Aktualisiert vorhandene Ticket.
        /// </summary>
        
        public async Task UpdateTicketAsync(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// löscht ein Ticket nach ID.
        /// </summary>
        
        public async Task DeleteTicketAsync(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
                await _context.SaveChangesAsync();
            }
        }
    }
}
