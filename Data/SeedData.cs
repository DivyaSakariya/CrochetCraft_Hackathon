using CrochetCraft.Models;
using Microsoft.AspNetCore.Identity;
namespace CrochetCraft.Data;
public static class SeedData { public static async Task Run(AppDbContext db) {
 if(!db.Users.Any()){var admin=new AppUser{Name="Craft Admin",Email="admin@crochetcraft.local",Role="Admin"};admin.PasswordHash=new PasswordHasher<AppUser>().HashPassword(admin,"Admin@12345");db.Users.Add(admin);}
 if(!db.Products.Any())db.Products.AddRange(new[]{new Product{Name="Heart Keychain",Category="Keychain",BasePrice=120,YarnGrams=18,Emoji="💗",Description="A tiny handmade keepsake."},new Product{Name="Rose Bouquet",Category="Bouquet",BasePrice=350,YarnGrams=90,Emoji="💐",Description="Flowers that last forever."},new Product{Name="Mini Crochet Bag",Category="Bag",BasePrice=550,YarnGrams=170,Emoji="👜",Description="A statement piece, made by hand."},new Product{Name="Teddy Plushie",Category="Plushie",BasePrice=450,YarnGrams=110,Emoji="🧸",Description="Soft, thoughtful and personal."}});
 if(!db.Materials.Any())db.Materials.AddRange(new Material{Name="Cotton Yarn",StockGrams=1500,ReorderLevel=300},new Material{Name="Velvet Yarn",StockGrams=450,ReorderLevel=200}); await db.SaveChangesAsync(); }
}