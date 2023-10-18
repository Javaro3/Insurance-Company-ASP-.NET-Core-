using lab3.Models;


namespace lab3.HtmlParsers
{
    public class HtmlFormVisitor : IHtmlVisitor
    {
        private int _formType;

        public HtmlFormVisitor(int formType)
        {
            _formType = formType;
        }

        public string Parse(AgentType agentType)
        {
            return
                $"<form action='/search_form{_formType}_AgentTypes' method='POST'>" +
                $"Название: <input type='text' name='Type{_formType}' value = '{agentType.Type}'>" +
                "<INPUT type ='submit' value='Показать'></FORM>";
        }

        public string Parse(Client client)
        {
            return
                $"<form action='/search_form{_formType}_Clients' method='POST'>" +
                $"Имя: <input type='text' name='ClientName{_formType}' value = {client.Name}>" +
                "<INPUT type ='submit' value='Показать'></FORM>";
        }

        public string Parse(Contract contract)
        {
            return
                $"<form action='/search_form{_formType}_Contracts' method='POST'>" +
                $"Ответственность: <input type='text' name='Responsibilities{_formType}' value = {contract.Responsibilities}>" +
                "<INPUT type ='submit' value='Показать'></FORM>";
        }

        public string Parse(InsuranceAgent insuranceAgent)
        {
            return
                $"<form action='/search_form{_formType}_InsuranceAgents' method='POST'>" +
                $"Зарплата: <input type='number' name='Salary{_formType}' value = {insuranceAgent.Salary}>" +
                "<INPUT type ='submit' value='Показать'></FORM>";
        }

        public string Parse(InsuranceCase insuranceCase)
        {
            return
                $"<form action='/search_form{_formType}_InsuranceCases' method='POST'>" +
                $"Страховая плата: <input type='number' name='InsurancePayment{_formType}' value = {insuranceCase.InsurancePayment}>" +
                "<INPUT type ='submit' value='Показать'></FORM>";
        }

        public string Parse(InsuranceType insuranceType)
        {
            return
                $"<form action='/search_form{_formType}_InsuranceTypes' method='POST'>" +
                $"название: <input type='text' name='InsuranceTypeName{_formType}' value = {insuranceType.Name}>" +
                "<INPUT type ='submit' value='Показать'></FORM>";
        }

        public string Parse(Policy policy)
        {
            return
                $"<form action='/search_form{_formType}_Policies' method='POST'>" +
                $"стоимость полиса: <input type='text' name='PolicyPayment{_formType}' value = {policy.PolicyPayment}>" +
                "<INPUT type ='submit' value='Показать'></FORM>";
        }

        public string Parse(PolicyInsuranceCase policyInsuranceCase)
        {
            return
                $"<form action='/search_form{_formType}_PolicyInsuranceCases' method='POST'>" +
                $"ID полиса: <input type='number' name='PolicyId{_formType}' value = {policyInsuranceCase.PolicyId}>" +
                "<INPUT type ='submit' value='Показать'></FORM>";
        }

        public string Parse(SupportingDocument supportingDocument)
        {
            return
                $"<form action='/search_form{_formType}_SupportingDocuments' method='POST'>" +
                $"название: <input type='text' name='SupportingDocumentName{_formType}' value = {supportingDocument.Name}>" +
                "<INPUT type ='submit' value='Показать'></FORM>";
        }
    }
}