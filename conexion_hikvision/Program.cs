
var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://187.216.118.73:5551").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                      });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();


}

app.UseCors("_myAllowSpecificOrigins");

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthentication();
app.UseMvc();

app.UseCors(MyAllowSpecificOrigins);

app.MapControllers();

app.Run();
