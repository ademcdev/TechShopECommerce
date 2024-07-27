using TechShop.API.Models.DapperContext;
using TechShop.API.Repos.CategoryRepos;
using TechShop.API.Repositories.ProductRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<DbContext>();
builder.Services.AddTransient<CategoryInterface, CategoryClass>();
builder.Services.AddTransient<ProductInterface, ProductClass>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
