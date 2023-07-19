using AutoMapper;
using DevIO.Api.Models;
using DevIO.Business.Models;

namespace DevIO.Api.Configuration
{
    public class AutommaperConfig : Profile
    {
        public AutommaperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
