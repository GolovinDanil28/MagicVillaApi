﻿using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
             new VillaDTO { Id = 1, Name = "Pool Viev", Occupancy =4, Sqft = 100 },
             new VillaDTO { Id = 2, Name = "Beach Viev", Occupancy =3, Sqft = 300  }
        };
    }
}
