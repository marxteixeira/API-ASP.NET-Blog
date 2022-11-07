using Blog.Data;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllers();
builder.Services.AddDbContext<BlogDataContext>();

app.MapControllers();

app.Run();
