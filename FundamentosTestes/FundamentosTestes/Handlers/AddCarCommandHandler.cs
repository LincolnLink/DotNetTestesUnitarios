using FundamentosTestes.Db;
using FundamentosTestes.Dtos;
using FundamentosTestes.Entities;
using FundamentosTestes.Handlers.Exceptions;
using FundamentosTestes.Services;
using MediatR;

namespace FundamentosTestes.Handlers;

internal class AddCarCommandHandler(ICarChassiValidatorService carChassiValidatorService, AppDbContext appDbContext)
    : IRequestHandler<AddCarCommand, CarDto>
{
    public async Task<CarDto> Handle(AddCarCommand request, CancellationToken cancellationToken)
    {
        // Generating Id
        var id = Guid.NewGuid();

        var isValidChassi = await carChassiValidatorService.CheckIfValidAsync(id, cancellationToken);

        if (!isValidChassi)
            throw new InvalidChassiException($"[{request.Nome}] chassi invalido!");

        var car = new Car(id, request.Nome);

        await appDbContext.Cars.AddAsync(car, cancellationToken);
        await appDbContext.SaveChangesAsync(cancellationToken);

        return new CarDto(car.Id, car.Name);
    }
}