using CrochetCraft.Data;using Microsoft.AspNetCore.Mvc;using Microsoft.EntityFrameworkCore;
namespace CrochetCraft.Controllers;
public class HomeController(AppDbContext db):Controller {public async Task<IActionResult> Index()=>View(await db.Products.Where(x=>x.Active).Take(4).ToListAsync());public IActionResult Error()=>View();}