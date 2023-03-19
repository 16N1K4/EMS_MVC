using EMS_MVC.Data;
using EMS_MVC.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//SQL Database
builder.Services.AddDbContext<EMSContext>();

builder.Services.AddScoped<EMSContext, EMSContext>();
builder.Services.AddScoped<IEMSRepoEmployee, EMSRepoEmployee>();
builder.Services.AddScoped<IEMSRepoDepartment, EMSRepoDepartment>();

//In-Memory Database
builder.Services.AddSingleton<IRepoEmpInMemory, RepoEmpInMemory>();
builder.Services.AddSingleton<IRepoDeptInMemory, RepoDeptInMemory>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=ViewAllEmployees}/{id?}");

app.Run();
