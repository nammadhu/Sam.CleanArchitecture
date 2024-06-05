﻿using AutoMapper;
using MyTown.SharedModels.Features.Cards.Commands;

namespace MyTown.SharedModels.DTOs
    {

    //todo change all these later
    public class TownApprovedCardDto : TownApprovedCard
        {
        private class Mapping : Profile
            {
            public Mapping()
                {
                CreateMap<TownApprovedCard, TownApprovedCardDto>().ReverseMap();
                }
            }
        }
    }
