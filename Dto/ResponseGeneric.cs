using System.Dynamic;
using System.Net;

namespace ApiTeste.Dto;
public class ResponseGeneric<T> where T : class
{
    public HttpStatusCode CodigoHttp { get; set; }
    public T? DadosRetorno { get; set; }
    public ExpandoObject? ErroRetorno { get; set; }
}
