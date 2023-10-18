using lab3.Models;

namespace lab3.Services
{
    public interface IFilterVisitor
    {
        IEnumerable<AgentType> Filter(IEnumerable<AgentType> agentTypes, AgentType agentType);
        IEnumerable<Client> Filter(IEnumerable<Client> clients, Client client);
        IEnumerable<Contract> Filter(IEnumerable<Contract> contracts, Contract contract);
        IEnumerable<InsuranceAgent> Filter(IEnumerable<InsuranceAgent> insuranceAgents, InsuranceAgent insuranceAgent);
        IEnumerable<InsuranceCase> Filter(IEnumerable<InsuranceCase> insuranceCases, InsuranceCase insuranceCase);
        IEnumerable<InsuranceType> Filter(IEnumerable<InsuranceType> insuranceTypes, InsuranceType insuranceType);
        IEnumerable<Policy> Filter(IEnumerable<Policy> policies, Policy policy);
        IEnumerable<PolicyInsuranceCase> Filter(IEnumerable<PolicyInsuranceCase> policyInsuranceCases, PolicyInsuranceCase policyInsuranceCase);
        IEnumerable<SupportingDocument> Filter(IEnumerable<SupportingDocument> supportingDocuments, SupportingDocument supportingDocument);
    }
}