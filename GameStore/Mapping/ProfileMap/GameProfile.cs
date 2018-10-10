using GameStore.DTOs;
using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Mapping.ProfileMap
{
    public class GameProfile :BaseProfile
    {
        protected override void CreateMap()
        {
            CreateMap<Game, GameDTOs>()
               .ForMember(pr => pr.Members,
                   opt => opt.MapFrom(p =>
                       p.Members.Select(pc => pc.User)))
               .ForMember(pr => pr.FavoriteMembers,
                   opt => opt.MapFrom(p =>
                       p.FavoriteMembers.Select(pc => pc.User)))
               .ForMember(pr => pr.Categories,
                   opt => opt.MapFrom(p =>
                       p.Categories.Select(pc => pc.Category)))
               .ForMember(pr => pr.Publisher, opt => opt.MapFrom(p => p.Publisher));
               
           
        }
    }
}
