using ApiTeste.Dto;
using ApiTeste.Model;
using AutoMapper;

namespace ApiTeste.Mapping;
public class BancoMapping : Profile
{
    public BancoMapping()
    {
        CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
        CreateMap<BancoResponse, Banco>();
        CreateMap<Banco, BancoResponse>();
    }
}
