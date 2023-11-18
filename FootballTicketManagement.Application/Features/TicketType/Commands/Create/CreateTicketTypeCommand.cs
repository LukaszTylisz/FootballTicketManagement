﻿using MediatR;

namespace FootballTicketManagement.Application.Features.TicketType.Commands.Create;

public class CreateTicketTypeCommand : IRequest<int>
{
    public string Name { get; set; } = string.Empty;
    public int DefaultResolutionTime { get; set; }
}