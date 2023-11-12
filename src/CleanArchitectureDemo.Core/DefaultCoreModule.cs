using Autofac;
using CleanArchitectureDemo.Core.Interfaces;
using CleanArchitectureDemo.Core.Services;

namespace CleanArchitectureDemo.Core;

/// <summary>
/// An Autofac module that is responsible for wiring up services defined in the Core project.
/// </summary>
public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<DeleteContributorService>()
        .As<IDeleteContributorService>().InstancePerLifetimeScope();
  }
}
