
var builder = WebApplication.CreateBuilder(args);

// Register MVC services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the request pipeline
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
	app.UseHttpsRedirection();
}
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

// Static assets
app.MapStaticAssets();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}")
	.WithStaticAssets();

app.Run();
