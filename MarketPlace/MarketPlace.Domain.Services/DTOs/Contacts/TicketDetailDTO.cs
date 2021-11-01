using MarketPlace.Domain.Entites.Contacts;
using System.Collections.Generic;

namespace MarketPlace.Domain.Services.DTOs.Contacts
{
    public class TicketDetailDTO
    {
        public Ticket Ticket { get; set; }
        public List<TicketMessage> TicketMessages { get; set; }
    }
}
