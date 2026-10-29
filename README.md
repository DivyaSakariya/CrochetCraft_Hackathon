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

<h1 align="center">📸 Project Screenshots</h1>

<h2>🏠 Main Page</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/b0cbad43-d379-4782-a3db-e87576c053b1" width="850" alt="Main Page">
</p>

<h2>🔐 User Login</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/fa4c6d17-f11b-4ecc-91e8-c268537c55b6" width="850" alt="Login Page">
</p>

<h2>📝 User Registration</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/3ebfb296-0294-41fc-a271-642ab218741d" width="850" alt="Registration Page">
</p>

<h2>📊 User Dashboard</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/9f9f27fd-aab5-4a89-af56-52bb7d0c5af4" width="850" alt="User Dashboard">
</p>

<h2>📈 Dashboard Overview</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/d8a9dfed-3faa-46aa-ab73-f4cadc58a318" width="850" alt="Dashboard Overview">
</p>

<h2>🛍️ Product Page</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/b05f2bbf-6a3d-4556-8834-51d2154eb408" width="850" alt="Product Page">
</p>

<h2>🎨 My Designs</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/c3944b71-ce70-4498-94e0-02cdc4dd4281" width="850" alt="My Designs">
</p>

<h2>🛒 Place Order</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/73fc8db6-8ec6-4773-b759-7aca35b3a378" width="850" alt="Place Order">
</p>

<h2>📦 My Orders</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/91e69c7b-a09c-4eaa-b716-93962bd4833a" width="850" alt="My Orders">
</p>

<hr>

<h1 align="center">🛡️ Admin Panel Screenshots</h1>

<h2>🔐 Admin Login</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/eed24ef8-e9cd-41f8-8448-a62999de1e0b" width="850" alt="Admin Login">
</p>

<h2>📊 Admin Dashboard</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/859bfb12-6001-45a2-b8d0-fa528e87e48c" width="850" alt="Admin Dashboard">
</p>

<h2>➕ Add Material</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/54806934-694b-48e8-bb30-2359d784c11c" width="850" alt="Add Material">
</p>

<h2>🧶 Yarn Inventory Management</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/a3032c2e-06a5-4404-a036-0c68ababd542" width="850" alt="Yarn Inventory">

</p>

<h2>📋 Customer Order Management</h2>
<p align="center">
  <img src="https://github.com/user-attachments/assets/087d2b45-f1d9-4480-a6f7-1087674a1455" width="850" alt="Customer Orders">

</p>

## Important
`EnsureCreated` is used for a straightforward XAMPP classroom setup. **Do not mix it with `dotnet ef migrations` on the same existing database.** To move to migrations later, start with a fresh database and remove `EnsureCreated`.
