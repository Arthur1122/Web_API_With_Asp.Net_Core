using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile:Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>()
                .ForMember(c => c.VenueName,o => o.MapFrom(m => m.Location.VenueName))
                .ForMember(c=> c.Talks,o=>o.MapFrom(m=>m.Talks))
                .ReverseMap();

            this.CreateMap<Talk, TalkModel>()
                .ReverseMap();

            this.CreateMap<TalkModel, Talk>();

            this.CreateMap<Speaker, SpeakerModel>();
            this.CreateMap<SpeakerModel, Speaker>();
        }
    }
}
