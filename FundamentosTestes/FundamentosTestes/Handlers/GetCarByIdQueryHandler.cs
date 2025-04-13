using FundamentosTestes.Dtos;
using FundamentosTestes.Db;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FundamentosTestes.Handlers;

internal sealed class GetCarByIdQueryHandler(AppDbContext dbContext) : IRequestHandler<GetCarByIdQuery, CarDto?>
{
    public async Task<CarDto?> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
    {
        var car = await dbContext.Cars.SingleOrDefaultAsync(x => x.Id == request.CardId, cancellationToken: cancellationToken);
        return car is null ? null : new CarDto(car.Id, car.Name);
    }

    //public Task<CarDto?> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
    //{
    //    throw new NotImplementedException();
    //}
}