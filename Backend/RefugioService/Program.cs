var builder = WebApplication.CreateBuilder(args);

//var MyAllowSpecificOrigins = "AllowWebApp";
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: MyAllowSpecificOrigins,
//                      policy =>
//                      {
//                          policy.WithOrigins("http://example.com",
//                                              "http://www.contoso.com");
//                      });
//});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
options.AddPolicy("AllowWebApp", build =>
build.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod())
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();
app.UseCors("AllowWebApp");

app.UseAuthorization();

app.MapControllers();

app.Run();
