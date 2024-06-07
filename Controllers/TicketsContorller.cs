using Microsoft.AspNetCore.Mvc;
using HelpdeskTicketSupportApp.Services;
using HelpdeskTicketSupportApp.Models;
using HelpdeskTicketSupportApp.DTOs;

namespace HelpdeskTicketSupportApp.Controllers
{   /// <summary>
    /// Kontroller für management von Ticket Objekts
    /// </summary>


    [ApiController]
    [Route("api/[controller]")]
    
  
    
    public class TicketsController : ControllerBase
    {   /// <summary>
        /// Ticket ControllerAlgemein
        /// </summary>
        private readonly TicketService _ticketService;

        /// <summary>
        /// Konstruktor für den TicketController
        /// </summary>
        /// <param name="ticketService">instanz des TicketService</param>
        public TicketsController(TicketService ticketService)
        {   
            _ticketService = ticketService;
        }

        /// <summary>
        /// Gibt Alle Tickets züruck
        /// </summary>
       

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetTickets()
        {
            var tickets = await _ticketService.GetAllTicketsAsync();
            var ticketDtos = tickets.Select(t => new TicketDto
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                Status = t.Status
            }).ToList();

            return Ok(ticketDtos);
        }
        /// <summary>
        /// Gibts eine Bestimmtes Ticket zürück nach ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>



        [HttpGet("{id}")]
        public async Task<ActionResult<TicketDto>> GetTicket(int id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            var ticketDto = new TicketDto
            {
                Id = ticket.Id,
                Title = ticket.Title,
                Description = ticket.Description,
                Status = ticket.Status
            };

            return Ok(ticketDto);
        }

        /// <summary>
        /// Erstellt ein neues Ticket.
        /// </summary>
        /// <param name="ticketDto">name</param>
        /// <returns>CreatedAtAction</returns>

        [HttpPost]
        public async Task<ActionResult<TicketDto>> CreateTicket(TicketDto ticketDto)
        {
            var ticket = new Ticket
            {
                Title = ticketDto.Title,
                Description = ticketDto.Description,
                Status = ticketDto.Status,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _ticketService.CreateTicketAsync(ticket);

            return CreatedAtAction(nameof(GetTicket), new { id = ticket.Id }, ticketDto);
        }

        /// <summary>
        /// Aktualisiert ein Vorhandenes Ticket nach ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="ticketDto">NAme</param>
        /// <returns>UpdateTicketAsync</returns>


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTicket(int id, TicketDto ticketDto)
        {
            if (id != ticketDto.Id)
            {
                return BadRequest();
            }

            var ticket = await _ticketService.GetTicketByIdAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            ticket.Title = ticketDto.Title;
            ticket.Description = ticketDto.Description;
            ticket.Status = ticketDto.Status;
            ticket.UpdatedAt = DateTime.UtcNow;

            await _ticketService.UpdateTicketAsync(ticket);

            return NoContent();
        }

        /// <summary>
        /// löscht ein bestimmtes Ticket nach ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>DeleteTicketAsync</returns>


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            await _ticketService.DeleteTicketAsync(id);

            return NoContent();
        }
    }
}
