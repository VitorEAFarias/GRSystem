using Microsoft.EntityFrameworkCore;
using GRSystem.DTO.Context;
using Microsoft.OpenApi.Models;
using System.Reflection;
using RO_Garantias.BLL.CLIENTESBLL;
using RO_Garantias.DAL.CLIENTESDAL;

var builder = WebApplication.CreateBuilder(args);

// Connection strings
string _conGADB = string.Format(builder.Configuration.GetConnectionString("GADB"), "GARANTIA", "WARRANTY");

// Add services to the container.
builder.Services.AddDbContext<GADBCONTEXT>(options => options.UseOracle(_conGADB, b => b.UseOracleSQLCompatibility("11")));

builder.Services.AddScoped<ICLIENTESDAL, CLIENTESDAL>();
builder.Services.AddScoped<ICLIENTESBLL, CLIENTESBLL>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "GRSystem",
        Description = "An ASP.NET Core Web API for managing ToDo items",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

    app.UseDeveloperExceptionPage();
    app.UseSwagger();

    app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "GRSystem"));

}
else
{
    app.UseHttpsRedirection();
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
