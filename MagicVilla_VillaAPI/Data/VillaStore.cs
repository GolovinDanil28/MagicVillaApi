using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
             new VillaDTO { Id=1, Name = "Pool Viev", Sqft = 100, Occupancy =4},
             new VillaDTO { Id = 2, Name = "Beach Viev", Sqft = 300, Occupancy =3 }
        };
    }
}
