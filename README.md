# CrochetCraft — ASP.NET Core MVC + XAMPP MySQL

## Requirements
- .NET 8 SDK
- XAMPP with MySQL/MariaDB running (port 3306 by default)
- Internet connection for initial NuGet restore and Bootstrap CDN

## Setup
1. Start **MySQL** in XAMPP (Apache optional, only needed for phpMyAdmin).
2. Open `http://localhost/phpmyadmin` and import `Database/create_database.sql` (or create `crochetcraft_db` manually).
3. Open `appsettings.json`. Default XAMPP usually uses `user=root;password=;`. If your password/port differs, update the connection string. Do not commit real credentials to public GitHub.
4. Open terminal inside this folder:
   ```powershell
   dotnet restore
   dotnet build
   dotnet run
   ```
5. Visit the localhost URL printed by `dotnet run`.
6. **Tables are created automatically by Entity Framework Core `EnsureCreated()`** when the app first starts; no `dotnet ef migrations add` is required. In phpMyAdmin, refresh `crochetcraft_db` to see tables.

## Demo logins
Admin: `admin@crochetcraft.local` / `Admin@12345`
Customer: use **Register** to create your own account.
**Change the admin password before any public deployment.** This account is only for local academic demonstration.

## Features
- Customer registration/login, secure password hashing, session state
- Browse products and design a custom item (color, pattern, size, name, bow, wrap, quantity)
- JavaScript live illustrative 2D preview + live pricing/yarn estimate
- Save designs, checkout with COD, view order tracking
- Admin dashboard, product CRUD (soft hide), material CRUD, low-stock indicator, order status updates
- Bootstrap responsive design

## Project scope / honesty
- This is a classroom MVP, **not** a production commerce platform.
- No online payment gateway, no actual 3D rendering or AI model.
- Price and yarn figures are estimates based on product settings.
- Yarn stock is maintained manually; orders do not automatically deduct yarn because products may use multiple yarn types.
- For a real deployment add HTTPS, ASP.NET Core Identity, authorization policies, email verification, production migrations, concurrency safeguards, inventory reservations, and audit logs.

## Important
`EnsureCreated` is used for a straightforward XAMPP classroom setup. **Do not mix it with `dotnet ef migrations` on the same existing database.** To move to migrations later, start with a fresh database and remove `EnsureCreated`.
