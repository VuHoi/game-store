using GameStore.DTOs;
using GameStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Mapping.ProfileMap
{
    public class UserProfile : BaseProfile
    {
        protected override void CreateMap()
        {
            CreateMap<User, UserDTOs>()
                .ForMember(pr => pr.Games,
                    opt => opt.MapFrom(p =>
                        p.Games.Select(pc => pc.Game)))
                .ForMember(pr => pr.WishGames,
                    opt => opt.MapFrom(p =>
                        p.WishGames.Select(pc => pc.Game)))

                .ForAllMembers(opt => opt.Condition(
                    (src, des, srcMbr, desMbr) => (srcMbr != null)));
            CreateMap<UserDTOs, User>()
                .ForMember(g => g.Email, opt => opt.Ignore())
                .ForMember(g => g.PhoneNumber, opt => opt.Ignore());
            CreateMap<RegisterDTOs, User>()
               .ForMember(g => g.UserName, opt => opt.MapFrom(u=>u.Email));
            CreateMap<User, RegisterDTOs>();
        }
    }
}
