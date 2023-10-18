using lab3.Data;
using lab3.HtmlParsers;
using lab3.LocalStorage.Cookies;
using lab3.LocalStorage.Sessions;
using lab3.Services;

namespace lab3.Handlers
{
    public class InsuranceCompanyHandlers   
    {
        public async void GetInfoPage(HttpContext context)
        {
            string responseContent = new HtmlBuilder()
                .SetTitile("Информация о запросе")
                .AddRequestInfo(context.Request)
                .AddBackMenuButton()
                .Build();

            await context.Response.WriteAsync(responseContent);
        }

        public async void GetMainPage(HttpContext context)
        {
            string header = "Главное меню";
            var tables = new List<string>() {
                "Таблица типов агентов", "Таблица клиентов", "Таблица контрактов",
                "Таблица страховых агентов", "Таблица страховых случаев", "Таблица типов срахования",
                "Таблица полисов", "Таблица страховых случаев с полисами", "Таблица дополнительных документов"
            };
            var search_form1 = new List<string>() {
                "search form1 типов агентов", "search form1 клиентов", "search form1 контрактов",
                "search form1 страховых агентов", "search form1 страховых случаев", "search form1 типов срахования",
                "search form1 полисов", "search form1 страховых случаев с полисами", "search form1 дополнительных документов"
            };
            var search_form2 = new List<string>() {
                "search form2 типов агентов", "search form2 клиентов", "search form2 контрактов",
                "search form2 страховых агентов", "search form2 страховых случаев", "search form2 типов срахования",
                "search form2 полисов", "search form2 страховых случаев с полисами", "search form2 дополнительных документов"
            };
            var tableNames = InsuranceCompanyContext.DbSetNames;

            List<(string Value, string Url)> list = new() {
                new ("Информация о запросе", "\\info")};

            for (int i = 0; i < tableNames.Count; i++)
            {
                list.Add(new(tables[i], "\\table_" + tableNames[i]));
            }

            for (int i = 0; i < tableNames.Count; i++)
            {
                list.Add(new(search_form1[i], "\\search_form1_" + tableNames[i]));
            }

            for (int i = 0; i < tableNames.Count; i++)
            {
                list.Add(new(search_form2[i], "\\search_form2_" + tableNames[i]));
            }

            string responseContent = new HtmlBuilder()
                .SetTitile("Информация о запросе")
                .AddListWithUrl(header, list)
                .Build();

            await context.Response.WriteAsync(responseContent);
        }

        public async void GetTablePage(HttpContext context, string tableName)
        {
            var cache = context.RequestServices.GetService<InsuranceCompanyСache>();
            var entites = cache.GetEnites(tableName);
            var responseContent = new HtmlBuilder()
                .AddTable(entites)
                .AddBackMenuButton()
                .Build();

            await context.Response.WriteAsync(responseContent);
        }

        public async void GetSearchForm1Page(HttpContext context, string tableName)
        {
            var cache = context.RequestServices.GetService<InsuranceCompanyСache>();
            var sessionsVisitor = new SessionsVisitor();
            var filter = new CacheFilter();

            var entities = cache.GetEnites(tableName);
            var entity = entities.FirstOrDefault().AcceptLocalData(sessionsVisitor, context);
            entities = entity.AcceptFilter(filter, entities);

            var responseContent = new HtmlBuilder()
                .AddForm(entity, 1)
                .AddTable(entities)
                .AddBackMenuButton()
                .Build();

            await context.Response.WriteAsync(responseContent);
        }

        public async void GetSearchForm2Page(HttpContext context, string tableName)
        {
            var cache = context.RequestServices.GetService<InsuranceCompanyСache>();
            var cookiesVisitor = new CookiesVisitor();
            var filter = new CacheFilter();

            var entities = cache.GetEnites(tableName);
            var entity = entities.FirstOrDefault().AcceptLocalData(cookiesVisitor, context);
            entities = entity.AcceptFilter(filter, entities);

            var responseContent = new HtmlBuilder()
                .AddForm(entity, 2)
                .AddTable(entities)
                .AddBackMenuButton()
                .Build();

            await context.Response.WriteAsync(responseContent);
        }
    }
}
