using Microsoft.EntityFrameworkCore;
using SchoolMVC.Business.Interfaces;
using SchoolMVC.Business.Services;
using SchoolMVC.Data.Context;
using SchoolMVC.Data.Interfaces;
using SchoolMVC.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITurmasService, TurmasService>();

builder.Services.AddScoped<ITurmaRepository, TurmaRepository>();

builder.Services.AddScoped<IAlunosService, AlunosService>();

builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SchoolContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
