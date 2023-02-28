using FluentValidation.AspNetCore;
using RentACarAPI.Application.Validators;
using RentACarAPI.Infrastructure.Filters;
using RentACarAPI.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Services();
builder.Services.AddCors(options => options.AddDefaultPolicy(
    x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
    ));

builder.Services.AddControllers(x => x.Filters.Add<Filter>()).AddFluentValidation(configuration =>
configuration.RegisterValidatorsFromAssemblyContaining<CreateCarViewModelValidator>())
    .ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
