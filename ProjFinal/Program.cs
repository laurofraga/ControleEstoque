using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjFinal.Data;
using ProjFinal.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProjFinalContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("ProjFinalContext") ?? throw new InvalidOperationException("Connection string 'ProjFinalContext' not found.")));

// Add services to the container.
builder.Services.AddDbContext<ProjFinalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjFinalContext") ?? throw new InvalidOperationException("Connection string 'ProjFinalContext' not found.")));
builder.Services.AddDefaultIdentity<Funcionario>(options =>
{
    options.SignIn.RequireConfirmedAccount = false; // Desabilitar confirmação de conta por e-mail para simplificar
}).AddEntityFrameworkStores<ProjFinalContext>();

//MVC services e razor pages
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
