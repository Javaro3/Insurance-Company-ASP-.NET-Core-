using lab3.HtmlParsers;
using lab3.LocalStorage;
using lab3.Services;

namespace lab3.Models;

public partial class InsuranceCase : IEntity {
    public int Id { get; set; }

    public int Client { get; set; }

    public int InsuranceAgent { get; set; }

    public DateTime Date { get; set; }

    public string? Description { get; set; }

    public int SupportingDocument { get; set; }

    public decimal InsurancePayment { get; set; }

    public virtual Client ClientNavigation { get; set; } = null!;

    public virtual InsuranceAgent InsuranceAgentNavigation { get; set; } = null!;

    public virtual SupportingDocument SupportingDocumentNavigation { get; set; } = null!;

    public IEnumerable<IEntity> AcceptFilter(IFilterVisitor visitor, IEnumerable<IEntity> entities) {
        return visitor.Filter(entities.Select(e => (InsuranceCase)e), this);
    }

    public string AcceptHtml(IHtmlVisitor visitor) {
        return visitor.Parse(this);
    }

    public IEntity AcceptLocalData(ILocalSaveVisitor visitor, HttpContext context) {
        return visitor.Save(this, context);
    }
}
