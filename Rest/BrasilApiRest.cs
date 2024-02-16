using System.Dynamic;
using System.Text.Json;
using ApiTeste.Dto;
using ApiTeste.Interface;
using ApiTeste.Model;

namespace ApiTeste.Rest;

public class BrasilApiRest : IBrasilApi
{
    public async Task<ResponseGeneric<Endereco>> BuscarEnderecoPorCEP(string cep)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

        var response = new ResponseGeneric<Endereco>();
        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<Endereco>(contentResp);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.DadosRetorno = objResponse;
            }
            else
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
        }
        return response;
    }

    public async Task<ResponseGeneric<List<Banco>>> BuscarTodosBancos()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");

        var response = new ResponseGeneric<List<Banco>>();
        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<List<Banco>>(contentResp);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.DadosRetorno = objResponse;
            }
            else
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
        }
        return response;
    }

    public async Task<ResponseGeneric<Banco>> BuscarBanco(string codigoBanco)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");

        var response = new ResponseGeneric<Banco>();
        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<Banco>(contentResp);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.DadosRetorno = objResponse;
            }
            else
            {
                response.CodigoHttp = responseBrasilApi.StatusCode;
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
        }
        return response;
    }
}
