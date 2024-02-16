using ApiTeste.Interface;
using ApiTeste.Mapping;
using ApiTeste.Rest;
using ApiTeste.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IEnderecoService, EnderecoService>();
builder.Services.AddSingleton<IBancoService, BancoService>();
builder.Services.AddSingleton<IBrasilApi, BrasilApiRest>();

builder.Services.AddAutoMapper(typeof(EnderecoMapping));
builder.Services.AddAutoMapper(typeof(BancoMapping));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
