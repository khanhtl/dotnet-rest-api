using Microsoft.AspNetCore.HttpOverrides;
using RestFullAPI.ServiceExtensions;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.ConfigureCors();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

}
else
{
    app.UseHsts();
}

app.UseStaticFiles();
app.UseForwardedHeaders(
    new ForwardedHeadersOptions
    {
        ForwardedHeaders = ForwardedHeaders.All
    }
);

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
