using api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IChallengeServices, ChallengeServices>(); 
builder.Services.AddScoped<IAddServices, AddServices>(); 
builder.Services.AddScoped<IGreaterServices, GreaterServices>(); 
builder.Services.AddScoped<IEightServices, EightServices>(); 
builder.Services.AddScoped<IRestaurantServices, RestaurantServices>(); 
builder.Services.AddScoped<IMadServices, MadServices>(); 

builder.Services.AddCors(options =>
{
    //we must name our policy so we can call it within our app
    options.AddPolicy("Frontend", policy =>
    {
        //Here we are going to let our app know which origins and request methods are allowed
        policy.AllowAnyOrigin()
        //Allows any request header like Content-type
        .AllowAnyHeader()
        //Allows any Http Method: GET, POST, PUT, DELETE http://localhost:5266/api/health/json
        .AllowAnyMethod();
    }); 

}); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("Frontend"); 

app.MapControllers();

app.Run();

internal interface IMathServices
{
}