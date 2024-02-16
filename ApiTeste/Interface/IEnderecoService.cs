using ApiTeste.Dto;

namespace ApiTeste.Interface;
public interface IEnderecoService
{
    Task<ResponseGeneric<EnderecoResponse>> BuscarEndereco(string cep);
}
