using API.Extensions;
using Application.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
   opt.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
   opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
   {
      Name = "Authorization",
      Type = SecuritySchemeType.ApiKey,
      Scheme = "Bearer",
      BearerFormat = "JWT",
      In = ParameterLocation.Header,
      Description = "JWT Authorization header using the Bearer scheme."
   });
   opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
        new string[] {}
        }
    });
});

builder.Services.AddCors(opt =>
{
   opt.AddPolicy("CorsPolicy", policy =>
   {
      policy.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:3000");
   });
});

// Database Connection
builder.Services.AddDbContext<DataContext>(opt =>
{
   opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddIdentityService(builder.Configuration);
builder.Services.AddScoped<IDataContext, DataContext>();
builder.Services.AddRepositoryServices();
builder.Services.AddCommandServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
   app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
