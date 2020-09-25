using Capitani.Domain.Entities;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAppCoreCapitani
{
    public interface IClienteApiService
    {
        [Get("/v1/Cliente/")]
        IEnumerable<ClienteResponse> Get();
        [Get("/v1/Cliente/{name}/json")]
        IEnumerable<ClienteResponse> GetByName(string name);
    }
}
