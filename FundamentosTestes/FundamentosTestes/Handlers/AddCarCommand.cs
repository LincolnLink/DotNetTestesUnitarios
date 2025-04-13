using FundamentosTestes.Dtos;
using MediatR;

namespace FundamentosTestes.Handlers;

internal record AddCarCommand(string Nome) : IRequest<CarDto>;