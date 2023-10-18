using lab3.Models;

namespace lab3.HtmlParsers
{
    public interface IHtmlVisitor
    {
        string Parse(AgentType agentType);
        string Parse(Client client);
        string Parse(Contract contract);
        string Parse(InsuranceAgent insuranceAgent);
        string Parse(InsuranceCase insuranceCase);
        string Parse(InsuranceType insuranceType);
        string Parse(Policy policy);
        string Parse(PolicyInsuranceCase policyInsuranceCase);
        string Parse(SupportingDocument supportingDocument);
    }
}
