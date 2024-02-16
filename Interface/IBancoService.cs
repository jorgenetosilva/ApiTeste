using ApiTeste.Dto;

namespace ApiTeste.Interface;
public interface IBancoService
{
    Task<ResponseGeneric<List<BancoResponse>>> BuscarTodos();
    Task<ResponseGeneric<BancoResponse>> BuscarBanco(string codigoBanco);
}
