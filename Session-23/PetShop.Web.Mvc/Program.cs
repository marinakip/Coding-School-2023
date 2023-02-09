using PetShop.EF.Repositories;
using PetShop.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IEntityRepository<Customer>, CustomerRepository>();
builder.Services.AddScoped<IEntityRepository<Employee>, EmployeeRepository>();
builder.Services.AddScoped<IEntityRepository<Pet>, PetRepository>();
builder.Services.AddScoped<IEntityRepository<PetFood>, PetFoodRepository>();
builder.Services.AddScoped<IEntityRepository<Transaction>, TransactionRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
