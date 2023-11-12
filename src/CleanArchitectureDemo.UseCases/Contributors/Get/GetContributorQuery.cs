using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArchitectureDemo.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
