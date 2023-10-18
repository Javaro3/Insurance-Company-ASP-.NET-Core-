using lab3.HtmlParsers;
using lab3.LocalStorage;
using lab3.Services;

namespace lab3.Models
{
    public interface IEntity {
        public string AcceptHtml(IHtmlVisitor visitor);
        public IEntity AcceptLocalData(ILocalSaveVisitor visitor, HttpContext context);
        public IEnumerable<IEntity> AcceptFilter(IFilterVisitor visitor, IEnumerable<IEntity> entities);
    }
}
