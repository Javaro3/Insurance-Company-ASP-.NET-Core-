using lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace lab3.Data;

public partial class InsuranceCompanyContext : DbContext
{
    public static List<string> DbSetNames = new InsuranceCompanyContext()
        .GetType()
        .GetProperties()
        .Where(p => p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
        .Select(p => p.Name)
        .ToList();
    
    public InsuranceCompanyContext(){}

    public InsuranceCompanyContext(DbContextOptions<InsuranceCompanyContext> options) : base(options) {}

    public virtual DbSet<AgentType> AgentTypes { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<InsuranceAgent> InsuranceAgents { get; set; }

    public virtual DbSet<InsuranceCase> InsuranceCases { get; set; }

    public virtual DbSet<InsuranceType> InsuranceTypes { get; set; }

    public virtual DbSet<Policy> Policies { get; set; }

    public virtual DbSet<PolicyInsuranceCase> PolicyInsuranceCases { get; set; }

    public virtual DbSet<SupportingDocument> SupportingDocuments { get; set; }
}