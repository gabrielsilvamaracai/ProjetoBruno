using Microsoft.EntityFrameworkCore;
using ProjetoBruno.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configuração do banco de dados.
builder.Services.AddDbContext<ConnectionContext>( options => {
    var connectionString = builder.Configuration.GetConnectionString("ConnectionContext");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//Add rota customizada
app.MapControllerRoute(
name: "alunos",
pattern: "Alunos/{action=Index}/{id?}",
defaults: new { controller = "Aluno" });

app.MapControllerRoute(
name: "cursos",
pattern: "Cursos/{action=Index}/{id?}",
defaults: new { controller = "Curso" });

app.Run();
