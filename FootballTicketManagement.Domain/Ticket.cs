﻿using FootballTicketManagement.Domain.Common;

namespace FootballTicketManagement.Domain;

public class Ticket : BaseEntity
{
    public DateTime MatchStartDate { get; set; }
    public DateTime MatchEndDate { get; set; }
    public int TicketTypeId { get; set; }
    public DateTime DateRequested { get; set; }
    public string TicketComments { get; set; }
    public bool Resolved { get; set; }
    public bool Cancelled { get; set; }
    //public string RequestingClientId { get; set; }
}