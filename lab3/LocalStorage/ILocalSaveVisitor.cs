using lab3.Models;

namespace lab3.LocalStorage
{
    public interface ILocalSaveVisitor
    {
        AgentType Save(AgentType agentType, HttpContext context);
        Client Save(Client client, HttpContext context);
        Contract Save(Contract contract, HttpContext context);
        InsuranceAgent Save(InsuranceAgent insuranceAgent, HttpContext context);
        InsuranceCase Save(InsuranceCase insuranceCase, HttpContext context);
        InsuranceType Save(InsuranceType insuranceType, HttpContext context);
        Policy Save(Policy policy, HttpContext context);
        PolicyInsuranceCase Save(PolicyInsuranceCase policyInsuranceCase, HttpContext context);
        SupportingDocument Save(SupportingDocument supportingDocument, HttpContext context);
    }
}
