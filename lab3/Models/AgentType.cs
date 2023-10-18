using lab3.HtmlParsers;
using lab3.LocalStorage;
using lab3.Services;

namespace lab3.Models;

public partial class AgentType : IEntity {
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<InsuranceAgent> InsuranceAgents { get; set; } = new List<InsuranceAgent>();

    public IEnumerable<IEntity> AcceptFilter(IFilterVisitor visitor, IEnumerable<IEntity> entities) {
        return visitor.Filter(entities.Select(e => (AgentType)e), this);
    }

    public string AcceptHtml(IHtmlVisitor visitor) {
        return visitor.Parse(this);
    }

    public IEntity AcceptLocalData(ILocalSaveVisitor visitor, HttpContext context) {
        return visitor.Save(this, context);
    }
}