using Blogv2.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.LoadConfiguration();
builder.ConfigureAuthentication();
builder.ConfigureMvc();
builder.ConfigureServices();

builder.Services.AddEndpointsApiExplorer(); // Utilizado para adicionar o swagger
builder.Services.AddSwaggerGen(); // Responsável por gerar o HTML do swagger

var app = builder.Build();

app.UseSwagger();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseResponseCompression();
app.UseStaticFiles();
app.MapControllers();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

if (app.Environment.IsDevelopment())
{
    Console.WriteLine("Estou no ambiente de desenvolvimento");
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();