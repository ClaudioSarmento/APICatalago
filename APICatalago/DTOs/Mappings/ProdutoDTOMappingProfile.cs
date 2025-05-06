﻿using APICatalago.Domain.Entities;
using AutoMapper;

namespace APICatalago.DTOs.Mappings;

public class ProdutoDTOMappingProfile : Profile
{
    public ProdutoDTOMappingProfile() {
        CreateMap<ProdutoDTO, Produto>().ReverseMap();
        CreateMap<CategoriaDTO, Categoria>().ReverseMap();
        CreateMap<Produto, ProdutoDTOUpdateRequest>().ReverseMap();
        CreateMap<Produto, ProdutoDTOUpdateResponse>().ReverseMap();
    }
}
