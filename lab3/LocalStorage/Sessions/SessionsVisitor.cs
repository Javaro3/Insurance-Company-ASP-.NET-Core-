using lab3.Models;

namespace lab3.LocalStorage.Sessions
{
    public class SessionsVisitor : ILocalSaveVisitor
    {
        public AgentType Save(AgentType agentType, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                var type = context.Request.Form["Type1"];
                var newAgentType = new AgentType { Type = type };
                context.Session.Set("AgentType", newAgentType);
                return newAgentType;
            }
            else
            {
                agentType = context.Session.Get<AgentType>("AgentType") ?? new AgentType();
                return agentType;
            }
        }

        public Client Save(Client client, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                var name = context.Request.Form["ClientName1"];
                var newClient = new Client { Name = name };
                context.Session.Set("Client", newClient);
                return newClient;
            }
            else
            {
                client = context.Session.Get<Client>("Client") ?? new Client();
                return client;
            }
        }

        public Contract Save(Contract contract, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                var responsibilities = context.Request.Form["Responsibilities1"];
                var newClient = new Contract { Responsibilities = responsibilities };
                context.Session.Set("Contract", newClient);
                return newClient;
            }
            else
            {
                contract = context.Session.Get<Contract>("Contract") ?? new Contract();
                return contract;
            }
        }

        public InsuranceAgent Save(InsuranceAgent insuranceAgent, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                decimal.TryParse(context.Request.Form["Salary1"], out var salary);
                var newInsuranceAgent = new InsuranceAgent { Salary = salary };
                context.Session.Set("InsuranceAgent", newInsuranceAgent);
                return newInsuranceAgent;
            }
            else
            {
                insuranceAgent = context.Session.Get<InsuranceAgent>("InsuranceAgent") ?? new InsuranceAgent();
                return insuranceAgent;
            }
        }

        public InsuranceCase Save(InsuranceCase insuranceCase, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                decimal.TryParse(context.Request.Form["InsurancePayment1"], out var insurancePayment);
                var newInsuranceCase = new InsuranceCase { InsurancePayment = insurancePayment };
                context.Session.Set("InsuranceCase", newInsuranceCase);
                return newInsuranceCase;
            }
            else
            {
                insuranceCase = context.Session.Get<InsuranceCase>("InsuranceCase") ?? new InsuranceCase();
                return insuranceCase;
            }
        }

        public InsuranceType Save(InsuranceType insuranceType, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                var name = context.Request.Form["InsuranceTypeName1"];
                var newInsuranceType = new InsuranceType { Name = name };
                context.Session.Set("InsuranceType", newInsuranceType);
                return newInsuranceType;
            }
            else
            {
                insuranceType = context.Session.Get<InsuranceType>("InsuranceType") ?? new InsuranceType();
                return insuranceType;
            }
        }

        public Policy Save(Policy policy, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                decimal.TryParse(context.Request.Form["PolicyPayment1"], out var policyPayment);
                var newPolicy = new Policy { PolicyPayment = policyPayment };
                context.Session.Set("Policy", newPolicy);
                return newPolicy;
            }
            else
            {
                policy = context.Session.Get<Policy>("Policy") ?? new Policy();
                return policy;
            }
        }

        public PolicyInsuranceCase Save(PolicyInsuranceCase policyInsuranceCase, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                int.TryParse(context.Request.Form["PolicyId1"], out var policyId);
                var newPolicyInsuranceCase = new PolicyInsuranceCase { PolicyId = policyId };
                context.Session.Set("PolicyInsuranceCase", newPolicyInsuranceCase);
                return newPolicyInsuranceCase;
            }
            else
            {
                policyInsuranceCase = context.Session.Get<PolicyInsuranceCase>("PolicyInsuranceCase") ?? new PolicyInsuranceCase();
                return policyInsuranceCase;
            }
        }

        public SupportingDocument Save(SupportingDocument supportingDocument, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                var name = context.Request.Form["SupportingDocumentName1"];
                var newSupportingDocument = new SupportingDocument { Name = name };
                context.Session.Set("SupportingDocument", newSupportingDocument);
                return newSupportingDocument;
            }
            else
            {
                supportingDocument = context.Session.Get<SupportingDocument>("SupportingDocument") ?? new SupportingDocument();
                return supportingDocument;
            }
        }
    }
}