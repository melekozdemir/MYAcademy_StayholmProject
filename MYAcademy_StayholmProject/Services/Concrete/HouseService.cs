using MYAcademy_StayholmProject.Dtos.HouseDtos;
using MYAcademy_StayholmProject.Services.Abstract;

namespace MYAcademy_StayholmProject.Services.Concrete
{
    public class HouseService : IHouseService
    {
        public Task CreateHouseAsync(CreateHouseDto createHouseDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHouseAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultHouseDto>> GetAllHousesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdHouseDto> GeyByIdHouseAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateHouseAsync(UpdateHouseDto updateHouseDto)
        {
            throw new NotImplementedException();
        }
    }
}
