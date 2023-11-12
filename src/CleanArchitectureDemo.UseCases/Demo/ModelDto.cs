using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.UseCases.Demo;
public record ModelDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
}
