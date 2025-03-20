using Microsoft.AspNetCore.Mvc;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// Funcionalidade - Endpoints
// Request-Requisição: 
// -> URL e Método HTTP
// -> Parâmetro é opcional

//Métodos HTTP:
    //GET - Pegar informação;
    //POST - Enviar informação;

app.MapGet("/", () => "Hello World!");

//GET: /testaurl
app.MapGet("/testarurl", () => "Primeira API");

//GET: /parametro/param
app.MapGet("/parametro/{param1}", ([FromRoute]string param1) => 
{
    string result = param1 + " " + DateTime.Now;
    return result;
});
    
app.Run();
