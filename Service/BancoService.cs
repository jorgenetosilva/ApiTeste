using ApiTeste.Dto;
using ApiTeste.Interface;
using ApiTeste.Model;
using AutoMapper;

namespace ApiTeste.Service
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGeneric<List<BancoResponse>>> BuscarTodos()
        {
            var bancos = await _brasilApi.BuscarTodosBancos();
            return _mapper.Map<ResponseGeneric<List<BancoResponse>>>(bancos);
        }

        public async Task<ResponseGeneric<BancoResponse>> BuscarBanco(string codigoBanco)
        {
            var banco = await _brasilApi.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseGeneric<BancoResponse>>(banco);
        }
    }
}