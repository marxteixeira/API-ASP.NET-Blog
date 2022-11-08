using Blog.Data;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers();
builder
    .Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });
builder.Services.AddDbContext<BlogDataContext>();


var app = builder.Build();


app.MapControllers();

app.Run();
