using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.UseCases.Contributors;
using MediatR;

namespace CleanArchitectureDemo.UseCases.Demo.List;
public record ListQuery : IRequest<IEnumerable<ModelDto>>;
