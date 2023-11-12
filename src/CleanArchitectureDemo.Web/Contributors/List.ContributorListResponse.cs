using CleanArchitectureDemo.Web.ContributorEndpoints;

namespace CleanArchitectureDemo.Web.Endpoints.ContributorEndpoints;

public class ContributorListResponse
{
  public List<ContributorRecord> Contributors { get; set; } = new();
}
