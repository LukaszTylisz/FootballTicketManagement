﻿using MediatR;

namespace FootballTicketManagement.Application.Features.TicketAllocation.Commands.Update;

public class UpdateTicketAllocationCommand : IRequest<Unit>
{
    public int Id { get; set; }
    public int NumberOfTickets { get; set; }
    public int TicketTypeId { get; set; }
    public int Period { get; set; }
}