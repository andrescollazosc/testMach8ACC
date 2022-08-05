using Mach8.TestACC.Application;
using Mach8.TestACC.Application.Abstractions;
using Mach8.TestACC.Application.Mapping;
using Mach8.TestACC.Core.Abstractions;
using Mach8.TestACC.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IMapper, Mapper>();
builder.Services.AddScoped<IOperationAppService, OperationAppService>();
builder.Services.AddScoped<IOperationService, OperationService>();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
