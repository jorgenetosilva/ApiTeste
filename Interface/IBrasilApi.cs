using ApiTeste.Dto;
using ApiTeste.Model;

namespace ApiTeste.Interface;
public interface IBrasilApi
{
    Task<ResponseGeneric<Endereco>> BuscarEnderecoPorCEP(string cep);
    Task<ResponseGeneric<List<Banco>>> BuscarTodosBancos();
    Task<ResponseGeneric<Banco>> BuscarBanco(string codigoBanco);
}
