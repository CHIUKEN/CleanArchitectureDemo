using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Core.Interfaces;
using CleanArchitectureDemo.UseCases.Contributors;
using Dapper;
using MediatR;

namespace CleanArchitectureDemo.UseCases.Demo.List;
public class ListHandler : IRequestHandler<ListQuery, IEnumerable<ModelDto>>
{
    private readonly ISqlConnectionFactory _connectionFactory;

    public ListHandler(ISqlConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<IEnumerable<ModelDto>> Handle(ListQuery request, CancellationToken cancellationToken)
    {
        using var connection = _connectionFactory.GetOpenConnection();
        var result = await connection.QueryAsync<ModelDto>("SELECT  Id, Name from Contributors c ");
        return result;
    }
}
