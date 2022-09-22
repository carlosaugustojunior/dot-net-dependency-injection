using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<FirstService>();
builder.Services.AddScoped<SecondService>();
builder.Services.AddTransient<ThirdService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", (
    FirstService firstService,
    SecondService secondService,
    ThirdService thirdService
    ) =>
new
{
    FirstServiceId = firstService.Id,
    SecondService = new
    {
        Id = secondService.Id,
        FirstServiceId = secondService.FirstServiceId
    },
    ThirdService = new
    {
        Id = thirdService.Id,
        FirstServiceId = thirdService.FirstServiceId,
        SecondServiceId = thirdService.SecondServiceId,
        SecondServiceNewInstanceId = thirdService.SecondServiceNewInstanceId
    }
});


app.Run();