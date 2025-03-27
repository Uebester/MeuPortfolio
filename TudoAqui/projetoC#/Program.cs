var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); //redireciona solicitações HTTP para HTTPS.
app.UseStaticFiles();

app.UseRouting(); //  adiciona a correspondência de rotas ao pipeline de middleware. Saiba mais em Roteamento no ASP.NET Core.

app.UseAuthorization(); //autoriza um usuário a acessar recursos seguros. Esse aplicativo não usa autorização, portanto, essa linha pode ser removida.

app.MapRazorPages(); // configura o roteamento de ponto de extremidade para Razor Pages.

app.Run(); // executa o aplicativo.

