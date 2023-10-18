using lab3.Models;

namespace lab3.Data {
    public static class InsuranceCompanyFactory {
        public static IEnumerable<IEntity> GetEnites(string entityName, InsuranceCompanyContext db) {
            switch (entityName) {
                case "AgentTypes":
                    return db.AgentTypes;
                case "Clients":
                    return db.Clients;
                case "Contracts":
                    return db.Contracts;
                case "InsuranceAgents":
                    return db.InsuranceAgents;
                case "InsuranceCases":
                    return db.InsuranceCases;
                case "InsuranceTypes":
                    return db.InsuranceTypes;
                case "Policies":
                    return db.Policies;
                case "PolicyInsuranceCases":
                    return db.PolicyInsuranceCases;
                case "SupportingDocuments":
                    return db.SupportingDocuments;
            }
            return null;
        }
    }
}
