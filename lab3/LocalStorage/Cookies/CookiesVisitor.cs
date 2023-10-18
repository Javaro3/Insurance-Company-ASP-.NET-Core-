using lab3.Models;

namespace lab3.LocalStorage.Cookies
{
    public class CookiesVisitor : ILocalSaveVisitor
    {
        public AgentType Save(AgentType agentType, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                var type = context.Request.Form["Type2"];
                context.Response.Cookies.Append("AgentType", type);
                return new AgentType() { Type = type };
            }
            else
            {
                if (context.Request.Cookies.ContainsKey("AgentType"))
                {
                    return new AgentType() { Type = context.Request.Cookies["AgentType"] };
                }
                return new AgentType();
            }
        }

        public Client Save(Client client, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                var name = context.Request.Form["ClientName2"];
                context.Response.Cookies.Append("Client", name);
                return new Client() { Name = name };
            }
            else
            {
                if (context.Request.Cookies.ContainsKey("Client"))
                {
                    return new Client() { Name = context.Request.Cookies["Client"] };
                }
                return new Client();
            }
        }

        public Contract Save(Contract contract, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                var responsibilities = context.Request.Form["Responsibilities2"];
                context.Response.Cookies.Append("Contract", responsibilities);
                return new Contract() { Responsibilities = responsibilities };
            }
            else
            {
                if (context.Request.Cookies.ContainsKey("Contract"))
                {
                    return new Contract() { Responsibilities = context.Request.Cookies["Contract"] };
                }
                return new Contract();
            }
        }

        public InsuranceAgent Save(InsuranceAgent insuranceAgent, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                decimal.TryParse(context.Request.Form["Salary2"], out var salary);
                context.Response.Cookies.Append("InsuranceAgent", salary.ToString());
                return new InsuranceAgent() { Salary = salary };
            }
            else
            {
                if (context.Request.Cookies.ContainsKey("InsuranceAgent"))
                {
                    return new InsuranceAgent() { Salary = decimal.Parse(context.Request.Cookies["InsuranceAgent"]) };
                }
                return new InsuranceAgent();
            }
        }

        public InsuranceCase Save(InsuranceCase insuranceCase, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                decimal.TryParse(context.Request.Form["InsurancePayment2"], out var insurancePayment);
                context.Response.Cookies.Append("InsuranceCase", insurancePayment.ToString());
                return new InsuranceCase() { InsurancePayment = insurancePayment };
            }
            else
            {
                if (context.Request.Cookies.ContainsKey("InsuranceCase"))
                {
                    return new InsuranceCase() { InsurancePayment = decimal.Parse(context.Request.Cookies["InsuranceCase"]) };
                }
                return new InsuranceCase();
            }
        }

        public InsuranceType Save(InsuranceType insuranceType, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                var insuranceTypeName = context.Request.Form["InsuranceTypeName2"];
                context.Response.Cookies.Append("InsuranceType", insuranceTypeName);
                return new InsuranceType() { Name = insuranceTypeName };
            }
            else
            {
                if (context.Request.Cookies.ContainsKey("InsuranceType"))
                {
                    return new InsuranceType() { Name = context.Request.Cookies["InsuranceType"] };
                }
                return new InsuranceType();
            }
        }

        public Policy Save(Policy policy, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                decimal.TryParse(context.Request.Form["PolicyPayment2"], out var policyPayment);
                context.Response.Cookies.Append("Policy", policyPayment.ToString());
                return new Policy() { PolicyPayment = policyPayment };
            }
            else
            {
                if (context.Request.Cookies.ContainsKey("Policy"))
                {
                    return new Policy() { PolicyPayment = decimal.Parse(context.Request.Cookies["Policy"]) };
                }
                return new Policy();
            }
        }

        public PolicyInsuranceCase Save(PolicyInsuranceCase policyInsuranceCase, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                int.TryParse(context.Request.Form["PolicyId2"], out var policyId);
                context.Response.Cookies.Append("PolicyInsuranceCase", policyId.ToString());
                return new PolicyInsuranceCase() { PolicyId = policyId };
            }
            else
            {
                if (context.Request.Cookies.ContainsKey("PolicyInsuranceCase"))
                {
                    return new PolicyInsuranceCase() { PolicyId = int.Parse(context.Request.Cookies["PolicyInsuranceCase"]) };
                }
                return new PolicyInsuranceCase();
            }
        }

        public SupportingDocument Save(SupportingDocument supportingDocument, HttpContext context)
        {
            if (context.Request.Method == "POST")
            {
                var name = context.Request.Form["SupportingDocumentName2"];
                context.Response.Cookies.Append("SupportingDocument", name);
                return new SupportingDocument() { Name = name };
            }
            else
            {
                if (context.Request.Cookies.ContainsKey("SupportingDocument"))
                {
                    return new SupportingDocument() { Name = context.Request.Cookies["SupportingDocument"] };
                }
                return new SupportingDocument();
            }
        }
    }
}
