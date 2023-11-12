using Ardalis.Result;
using Ardalis.SharedKernel;

namespace CleanArchitectureDemo.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
