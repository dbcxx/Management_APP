using backend_dotnet.Core.DbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

//DB section init .... it works directly with migrations folder
builder.Services.AddDbContext<ApplicationDbContext>(options =>

    {
        var connectionString = builder.Configuration.GetConnectionString("local");
        options.UseSqlServer(connectionString);
    });



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
