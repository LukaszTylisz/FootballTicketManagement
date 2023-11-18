﻿using MediatR;

namespace FootballTicketManagement.Application.Features.TicketType.Commands.Delete;

public class DeleteTicketTypeCommand : IRequest<Unit>
{
    public int Id { get; set; }
}