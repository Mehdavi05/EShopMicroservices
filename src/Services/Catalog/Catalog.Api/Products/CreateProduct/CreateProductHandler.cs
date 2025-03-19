using System.Security.Cryptography;
using BuildingBlocks.CQRS;
using Catalog.Api.Models;
using MediatR;

namespace Catalog.Api.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price): ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);

internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //Create product entity from command object
        var product = new Product
        {
            Name = command.Name,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };
        
        //TODO: Save entity to the database
        
        //Return the result
        return new CreateProductResult(Guid.NewGuid());
    }
}