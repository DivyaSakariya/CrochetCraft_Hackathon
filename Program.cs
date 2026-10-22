using CrochetCraft.Data;
using Microsoft.EntityFrameworkCore;
var builder=WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(o=>{o.IdleTimeout=TimeSpan.FromHours(3);o.Cookie.HttpOnly=true;o.Cookie.IsEssential=true;});
var cs=builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.AddDbContext<AppDbContext>(o=>o.UseMySql(cs,ServerVersion.AutoDetect(cs)));
var app=builder.Build();
if(!app.Environment.IsDevelopment()){app.UseExceptionHandler("/Home/Error");app.UseHsts();}
app.UseStaticFiles();app.UseRouting();app.UseSession();
using(var scope=app.Services.CreateScope()) { var db=scope.ServiceProvider.GetRequiredService<AppDbContext>(); db.Database.EnsureCreated(); await SeedData.Run(db); }
app.MapControllerRoute(name:"default",pattern:"{controller=Home}/{action=Index}/{id?}");
app.Run();