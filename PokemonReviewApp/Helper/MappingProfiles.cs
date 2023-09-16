using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Pokemon, PokemonDto>();
        CreateMap<PokemonDto, Pokemon>();
        
        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryDto, Category>();
        
        CreateMap<CountryDto, Country>();
        CreateMap<Country, CountryDto>();
        
        CreateMap<Owner, OwnerDto>();
        CreateMap<OwnerDto, Owner>();
        
        CreateMap<Reviewer, ReviewerDto>();
        CreateMap<ReviewerDto, Reviewer>();
        
        CreateMap<Review, ReviewDto>();
        CreateMap<ReviewDto, Review>();
    }
}