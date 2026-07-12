// Corrigido o 'l' minúsculo em WebApplication
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Mantém a rota inicial (Home)
app.MapGet("/", () => "Bem-vindo à API de Estoque! Acesse /produtos para ver os itens.");

// SUA NOVA ROTA DO EXERCÍCIO: http://localhost:5195/oficina
app.MapGet("/oficina", () => "Oficina Master - Gestão de Estoque Ativa! Localizada em São Paulo.");

app.Run();