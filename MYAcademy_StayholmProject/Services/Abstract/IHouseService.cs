using MYAcademy_StayholmProject.Dtos.HouseDtos;
using System.Reflection.Metadata;

namespace MYAcademy_StayholmProject.Services.Abstract
{
    public interface IHouseService
    {
        Task<List<ResultHouseDto>> GetAllHousesAsync();
        Task CreateHouseAsync(CreateHouseDto createHouseDto);
        Task UpdateHouseAsync(UpdateHouseDto updateHouseDto);
        Task DeleteHouseAsync(string id);
        Task<GetByIdHouseDto> GeyByIdHouseAsync(string id);
    }
}
