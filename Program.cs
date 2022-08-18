var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<CpfServices>(p =>
{
    int seed = DateTime.Now>millisecond;
    CpfServices service = new CpfServices();
    return service;
});

builder.Services.AddSingleton<CEPService>(p =>
{
    string baseUrl = 
    CEPService service = new CEPService(baseUrl);
    return Service;
}

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
