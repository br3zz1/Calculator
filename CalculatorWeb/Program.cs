using CalculatorWeb.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

builder.Services.AddSingleton<ICalculationService, CalculationService>();

var app = builder.Build();

app.MapControllers();
app.MapDefaultControllerRoute();
app.UseStaticFiles();

app.Run();
