using ApiTeste.Dto;
using ApiTeste.Interface;
using AutoMapper;

namespace ApiTeste.Service;
public class EnderecoService : IEnderecoService
{
    private readonly IMapper _mapper;
    private readonly IBrasilApi _brasilApi;

    public EnderecoService(IMapper mapper, IBrasilApi brasilApi)
    {
        _mapper = mapper;
        _brasilApi = brasilApi;
    }
    public async Task<ResponseGeneric<EnderecoResponse>> BuscarEndereco(string cep)
    {
        var endereco = await _brasilApi.BuscarEnderecoPorCEP(cep);
        return _mapper.Map<ResponseGeneric<EnderecoResponse>>(endereco);
    }

}
