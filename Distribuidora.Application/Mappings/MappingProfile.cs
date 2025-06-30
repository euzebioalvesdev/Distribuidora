using AutoMapper;
using Distribuidora.Application.DTOs;
using Distribuidora.Core.Entities;

namespace Distribuidora.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Produto
            CreateMap<Produto, ProdutoDTO>()
                .ForMember(dest => dest.NomeCategoria, opt => opt.MapFrom(src => src.Categoria.Nome));
            CreateMap<CreateProdutoDTO, Produto>();
            CreateMap<UpdateProdutoDTO, Produto>();

            // Categoria
            CreateMap<Categoria, CategoriaDTO>();
            CreateMap<CreateCategoriaDTO, Categoria>();
            CreateMap<UpdateCategoriaDTO, Categoria>();

            // Cliente
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<CreateClienteDTO, Cliente>();
            CreateMap<UpdateClienteDTO, Cliente>();

            // Venda
            CreateMap<Venda, VendaDTO>()
                .ForMember(dest => dest.NomeCliente, opt => opt.MapFrom(src => src.Cliente.Nome));
            CreateMap<CreateVendaDTO, Venda>();
            CreateMap<UpdateVendaDTO, Venda>();

            // Itens da Venda
            CreateMap<ItemVenda, ItemVendaDTO>()
                .ForMember(dest => dest.NomeProduto, opt => opt.MapFrom(src => src.Produto.Nome));
            CreateMap<CreateItemVendaDTO, ItemVenda>();
            CreateMap<UpdateItemVendaDTO, ItemVenda>();
        }
    }

}
