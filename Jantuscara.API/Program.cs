using Jantuscara.Application.Interfaces.UseCases.Recipe;
using Jantuscara.Application.UseCases.Recipe;
using Jantuscara.Domain.Interfaces;
using Jantuscara.Infrastructure.Configurations;
using Jantuscara.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<ICreateRecipeUseCase, CreateRecipeUseCase>();
//builder.Services.AddScoped<IDeleteRecipeUseCase, DeleteRecipeUseCase>();
//builder.Services.AddScoped<IGetRecipeByIdUseCase, GetRecipeByIdUseCase>();
//builder.Services.AddScoped<IUpdateRecipeUseCase, UpdateRecipeUseCase>();

builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext(builder.Configuration);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
