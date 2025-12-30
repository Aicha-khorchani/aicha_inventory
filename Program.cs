using InventoryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using InventoryApp;

var builder = WebApplication.CreateBuilder(args);

// Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Razor Pages (required for MapFallbackToPage)
builder.Services.AddRazorPages();

// Add Blazor services
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add authentication/authorization if needed (optional)
// builder.Services.AddAuthentication(...);
// builder.Services.AddAuthorization(...);

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// --- ANTIFORGERY MUST GO AFTER ROUTING ---
app.UseAntiforgery();

// Optional: Authentication/Authorization
// app.UseAuthentication();
// app.UseAuthorization();

// Map Blazor components
app.MapRazorComponents<Routes>()
    .AddInteractiveServerRenderMode();

// Fallback to _Host.cshtml
app.MapFallbackToPage("/_Host");

app.Run();
