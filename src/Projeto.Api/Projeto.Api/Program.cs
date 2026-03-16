using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

// Programa mínimo para inicializar a Web API.
// Conforme instruções do trabalho, não há controladores ou endpoints definidos.

var builder = WebApplication.CreateBuilder(args);

// Registra serviços necessários para a API. Nenhum serviço adicional é configurado neste estágio.
// builder.Services.AddControllers();

var app = builder.Build();

// Configuração mínima da pipeline de requisições. Não há mapeamento de controllers.
//app.MapControllers();

app.Run();
