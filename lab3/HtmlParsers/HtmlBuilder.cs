using lab3.Models;
using System.Text;


namespace lab3.HtmlParsers
{
    public class HtmlBuilder
    {
        private string _title = "default title";
        private string _body = "";

        public HtmlBuilder SetTitile(string title)
        {
            _title = title;
            return this;
        }

        public HtmlBuilder AddRequestInfo(HttpRequest request)
        {
            var htmlRequestInfo = "<div style=\"text-align: center;\"><H1>Информация о клиенте</H1>";
            htmlRequestInfo += $"<h3>Сервер: {request.Host}</h3>";
            htmlRequestInfo += $"<h3>Путь: {request.PathBase}</h3>";
            htmlRequestInfo += $"<h3>Протокол: {request.Protocol}</h3>";
            htmlRequestInfo += $"<h3>Метод: {request.Method}</h3>";
            htmlRequestInfo += $"<h3>Схема: {request.Scheme}</h3>";
            _body += htmlRequestInfo;
            return this;
        }

        public HtmlBuilder AddBackMenuButton()
        {
            _body += "<h3><a href=\"\\\">Главная</a></h3>";
            return this;
        }

        public HtmlBuilder AddListWithUrl(string header, IEnumerable<(string Value, string Url)> itemsWithUrl)
        {
            var htmlList = $"<div style=\"text-align: center;\"><H1>{header}</H1><ul>";
            foreach (var item in itemsWithUrl)
            {
                htmlList += $"<li><a href={item.Url}>{item.Value}</a></li>";
            }
            htmlList += "</ul>";

            _body += htmlList;
            return this;
        }

        public HtmlBuilder AddTable(IEnumerable<IEntity> entities)
        {
            var htmlTable = "<div style =\"text-align: center;\"><table border='1'>";
            var htmlParse = new HtmlTableVisitor();
            foreach (var entity in entities)
            {
                htmlTable += entity.AcceptHtml(htmlParse);
            }
            htmlTable += "</table>";
            _body += htmlTable;
            return this;
        }

        public HtmlBuilder AddForm(IEntity entity, int formType)
        {
            var htmlParser = new HtmlFormVisitor(formType);
            var htmlForm = entity.AcceptHtml(htmlParser);
            _body += htmlForm;
            return this;
        }

        public string Build()
        {
            var htmlPage = new StringBuilder();
            htmlPage.Append($"<HTML><HEAD><TITLE>{_title}</TITLE></HEAD><META http-equiv='Content-Type' content='text/html; charset=utf-8'/><BODY>");
            htmlPage.Append(_body);
            htmlPage.Append("</div></BODY></HTML>");
            return htmlPage.ToString();
        }
    }
}