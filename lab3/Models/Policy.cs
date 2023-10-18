using lab3.HtmlParsers;
using lab3.LocalStorage;
using lab3.Services;

namespace lab3.Models;

public partial class Policy : IEntity {
    public int Id { get; set; }

    public int InsuranceAgent { get; set; }

    public DateTime ApplicationDate { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public int InsuranceType { get; set; }

    public int Client { get; set; }

    public int PolicyTerm { get; set; }

    public decimal PolicyPayment { get; set; }

    public virtual Client ClientNavigation { get; set; } = null!;

    public virtual InsuranceAgent InsuranceAgentNavigation { get; set; } = null!;

    public virtual InsuranceType InsuranceTypeNavigation { get; set; } = null!;

    public IEnumerable<IEntity> AcceptFilter(IFilterVisitor visitor, IEnumerable<IEntity> entities) {
        return visitor.Filter(entities.Select(e => (Policy)e), this);
    }

    public string AcceptHtml(IHtmlVisitor visitor) {
        return visitor.Parse(this);
    }

    public IEntity AcceptLocalData(ILocalSaveVisitor visitor, HttpContext context) {
        return visitor.Save(this, context);
    }
}