using lab3.HtmlParsers;
using lab3.LocalStorage;
using lab3.Services;
using System.ComponentModel.DataAnnotations;

namespace lab3.Models;

public partial class PolicyInsuranceCase : IEntity {
    [Key]
    public int PolicyId { get; set; }

    public int InsuranceCaseId { get; set; }

    public virtual InsuranceCase InsuranceCase { get; set; } = null!;

    public virtual Policy Policy { get; set; } = null!;

    public IEnumerable<IEntity> AcceptFilter(IFilterVisitor visitor, IEnumerable<IEntity> entities) {
        return visitor.Filter(entities.Select(e => (PolicyInsuranceCase)e), this);
    }

    public string AcceptHtml(IHtmlVisitor visitor) {
        return visitor.Parse(this);
    }

    public IEntity AcceptLocalData(ILocalSaveVisitor visitor, HttpContext context) {
        return visitor.Save(this, context);
    }
}
