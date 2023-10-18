using lab3.Models;
using Microsoft.IdentityModel.Tokens;

namespace lab3.Services
{
    public class CacheFilter : IFilterVisitor {
        public IEnumerable<AgentType> Filter(IEnumerable<AgentType> agentTypes,  AgentType agentType) {
            return agentTypes.Where(e => agentType.Type.IsNullOrEmpty() || e.Type.Trim() == agentType.Type.Trim());
        }

        public IEnumerable<Client> Filter(IEnumerable<Client> clients, Client client) {
            return clients.Where(e => client.Name.IsNullOrEmpty() || e.Name.Trim() == client.Name.Trim());
        }

        public IEnumerable<Contract> Filter(IEnumerable<Contract> contracts, Contract contract) {
            return contracts.Where(e => contract.Responsibilities.IsNullOrEmpty() || e.Responsibilities.Trim() == contract.Responsibilities.Trim());
        }

        public IEnumerable<InsuranceAgent> Filter(IEnumerable<InsuranceAgent> insuranceAgents, InsuranceAgent insuranceAgent) {
            return insuranceAgents.Where(e => insuranceAgent.Salary == 0|| e.Salary > insuranceAgent.Salary);
        }
        public IEnumerable<InsuranceCase> Filter(IEnumerable<InsuranceCase> insuranceCases, InsuranceCase insuranceCase) {
            return insuranceCases.Where(e => insuranceCase.InsurancePayment == 0 || e.InsurancePayment > insuranceCase.InsurancePayment);
        }

        public IEnumerable<InsuranceType> Filter(IEnumerable<InsuranceType> insuranceTypes, InsuranceType insuranceType) {
            return insuranceTypes.Where(e => insuranceType.Name.IsNullOrEmpty() || e.Name.Trim() == insuranceType.Name.Trim());
        }

        public IEnumerable<Policy> Filter(IEnumerable<Policy> policies, Policy policy) {
            return policies.Where(e => policy.PolicyPayment == 0 || e.PolicyPayment > policy.PolicyPayment);
        }

        public IEnumerable<PolicyInsuranceCase> Filter(IEnumerable<PolicyInsuranceCase> policyInsuranceCases, PolicyInsuranceCase policyInsuranceCase) {
            return policyInsuranceCases.Where(e => policyInsuranceCase.PolicyId == 0 || e.PolicyId > policyInsuranceCase.PolicyId);
        }

        public IEnumerable<SupportingDocument> Filter(IEnumerable<SupportingDocument> supportingDocuments, SupportingDocument supportingDocument) {
            return supportingDocuments.Where(e => supportingDocument.Name.IsNullOrEmpty() || e.Name.Trim() == supportingDocument.Name.Trim());
        }
    }
}