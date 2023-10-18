using lab3.Data;
using lab3.Handlers;
using Microsoft.EntityFrameworkCore;


internal class Program {
    private static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddDbContext<InsuranceCompanyContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("InsuranceCompany")));
        builder.Services.AddTransient<InsuranceCompanyÑache>();
        builder.Services.AddMemoryCache();
        builder.Services.AddDistributedMemoryCache();
        builder.Services.AddSession();

        var app = builder.Build();
        app.UseSession();
        app.UseCookiePolicy();

        var handler = new InsuranceCompanyHandlers();
        var tables = InsuranceCompanyContext.DbSetNames;


        app.Map("/info", (appBuilder) => appBuilder.Run(async (context) => handler.GetInfoPage(context)));
        foreach (var table in tables){
            app.Map($"/table_{table}", (appBuilder) => appBuilder.Run(async (context) => handler.GetTablePage(context, table)));
        }
        foreach (var table in tables) {
            app.Map($"/search_form1_{table}", (appBuilder) => appBuilder.Run(async (context) => handler.GetSearchForm1Page(context, table)));
        }
        foreach (var table in tables) {
            app.Map($"/search_form2_{table}", (appBuilder) => appBuilder.Run(async (context) => handler.GetSearchForm2Page(context, table)));
        }

        app.Run(async (context) => handler.GetMainPage(context));

        app.Run();
    }
}