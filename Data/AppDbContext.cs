using Microsoft.EntityFrameworkCore;
using HelpdeskTicketSupportApp.Models;
using System.Collections.Generic;

namespace HelpdeskTicketSupportApp.Data
{   /// <summary>
    /// Datenbank Kontext
    /// </summary>
    public class AppDbContext : DbContext
    {   /// <summary>
    /// Kontruktor fur DBKontext
    /// </summary>
    /// <param name="options">options für DB kontext</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        /// <summary>
        /// DBset für Tickets
        /// </summary>
        public DbSet<Ticket> Tickets { get; set; }
        /// <summary>
        /// DB Set Für benutzer
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}
