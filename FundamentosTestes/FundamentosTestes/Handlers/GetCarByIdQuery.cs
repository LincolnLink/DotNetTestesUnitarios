using FundamentosTestes.Dtos;
using FundamentosTestes.Entities;
using MediatR;

namespace FundamentosTestes.Handlers;

internal record GetCarByIdQuery(Guid CardId) : IRequest<CarDto?>;