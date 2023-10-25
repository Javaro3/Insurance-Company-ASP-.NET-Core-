using lab3.Models;

namespace lab3.HtmlParsers
{
    public class HtmlTableVisitor : IHtmlVisitor
    {
        public string Parse(AgentType agentType)
        {
            return
                $"<tr>" +
                    $"<td>{agentType.Id}</td>" +
                    $"<td>{agentType.Type}</td>" +
                $"</tr>";
        }

        public string Parse(Client client)
        {
            return
                $"<tr>" +
                    $"<td>{client.Id}</td>" +
                    $"<td>{client.Name}</td>" +
                    $"<td>{client.Surname}</td>" +
                    $"<td>{client.MiddleName}</td>" +
                    $"<td>{client.Birthdate}</td>" +
                    $"<td>{client.MobilePhone}</td>" +
                    $"<td>{client.City}</td>" +
                    $"<td>{client.Street}</td>" +
                    $"<td>{client.House}</td>" +
                    $"<td>{client.Apartment}</td>" +
                    $"<td>{client.PassportNumber}</td>" +
                    $"<td>{client.PassportIdentification}</td>" +
                    $"<td>{client.PassportIssueDate}</td>" +
                $"</tr>";
        }

        public string Parse(Contract contract)
        {
            return
                $"<tr>" +
                    $"<td>{contract.Id}</td>" +
                    $"<td>{contract.Responsibilities}</td>" +
                    $"<td>{contract.StartDeadline}</td>" +
                    $"<td>{contract.EndDeadline}</td>" +
                $"</tr>";
        }

        public string Parse(InsuranceAgent insuranceAgent)
        {
            return
                $"<tr>" +
                    $"<td>{insuranceAgent.Id}</td>" +
                    $"<td>{insuranceAgent.Name}</td>" +
                    $"<td>{insuranceAgent.Surname}</td>" +
                    $"<td>{insuranceAgent.MiddleName}</td>" +
                    $"<td>{insuranceAgent.Salary}</td>" +
                    $"<td>{insuranceAgent.TransactionPercent}</td>" +
                    $"<td>{insuranceAgent.Contract}</td>" +
                    $"<td>{insuranceAgent.AgentType}</td>" +
                $"</tr>";
        }

        public string Parse(InsuranceCase insuranceCase)
        {
            return
                $"<tr>" +
                    $"<td>{insuranceCase.Id}</td>" +
                    $"<td>{insuranceCase.Date}</td>" +
                    $"<td>{insuranceCase.InsurancePayment}</td>" +
                    $"<td>{insuranceCase.SupportingDocument}</td>" +
                $"</tr>";
        }

        public string Parse(InsuranceType insuranceType)
        {
            return
                $"<tr>" +
                    $"<td>{insuranceType.Id}</td>" +
                    $"<td>{insuranceType.Name}</td>" +
                    $"<td>{insuranceType.Description}</td>" +
                $"</tr>";
        }

        public string Parse(Policy policy)
        {
            return
                $"<tr>" +
                    $"<td>{policy.Id}</td>" +
                    $"<td>{policy.PolicyNumber}</td>" +
                    $"<td>{policy.PolicyPayment}</td>" +
                    $"<td>{policy.PolicyTerm}</td>" +
                    $"<td>{policy.ApplicationDate}</td>" +
                    $"<td>{policy.Client}</td>" +
                    $"<td>{policy.InsuranceAgent}</td>" +
                    $"<td>{policy.InsuranceType}</td>" +
                $"</tr>";
        }

        public string Parse(PolicyInsuranceCase policyInsuranceCase)
        {
            return
                $"<tr>" +
                    $"<td>{policyInsuranceCase.PolicyId}</td>" +
                    $"<td>{policyInsuranceCase.InsuranceCaseId}</td>" +
                $"</tr>";
        }

        public string Parse(SupportingDocument supportingDocument)
        {
            return
                $"<tr>" +
                    $"<td>{supportingDocument.Id}</td>" +
                    $"<td>{supportingDocument.Name}</td>" +
                    $"<td>{supportingDocument.Description}</td>" +
                $"</tr>";
        }
    }
}
