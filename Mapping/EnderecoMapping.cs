using ApiTeste.Dto;
using ApiTeste.Model;
using AutoMapper;

namespace ApiTeste.Mapping;
public class EnderecoMapping : Profile
{
    public EnderecoMapping()
    {
        CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
        CreateMap<EnderecoResponse, Endereco>();
        CreateMap<Endereco, EnderecoResponse>();
    }
}
