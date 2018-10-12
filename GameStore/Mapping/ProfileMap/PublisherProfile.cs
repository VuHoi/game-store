using GameStore.DTOs;
using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Mapping.ProfileMap
{
    public class PublisherProfile : BaseProfile
    {
        protected override void CreateMap()
        {
            CreateMap<Publisher, PublisherDTOs>()
            .ForMember(pr => pr.Games, opt => opt.MapFrom(p => p.Games));

            CreateMap<PublisherDTOs, Publisher>();
            
            CreateMap<SavedPublisherDTOs, Publisher>();
            CreateMap<Publisher, SavedPublisherDTOs>();
        }
    }
}
