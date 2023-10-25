using lab3.HtmlParsers;
using lab3.LocalStorage;
using lab3.Services;

namespace lab3.Models;

public partial class InsuranceAgent : IEntity {
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public int AgentType { get; set; }

    public decimal Salary { get; set; }

    public int Contract { get; set; }

    public double TransactionPercent { get; set; }

    public virtual AgentType AgentTypeNavigation { get; set; } = null!;

    public virtual Contract ContractNavigation { get; set; } = null!;

    public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();

    public IEnumerable<IEntity> AcceptFilter(IFilterVisitor visitor, IEnumerable<IEntity> entities) {
        return visitor.Filter(entities.Select(e => (InsuranceAgent)e), this);
    }

    public string AcceptHtml(IHtmlVisitor visitor) {
        return visitor.Parse(this);
    }

    public IEntity AcceptLocalData(ILocalSaveVisitor visitor, HttpContext context) {
        return visitor.Save(this, context);
    }
}
