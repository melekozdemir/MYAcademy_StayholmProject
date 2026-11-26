using MYAcademy_StayholmProject.Dtos.AppUserDtos;

namespace MYAcademy_StayholmProject.Services.Abstract
{
    public interface IAppUserService
    {
        Task<List<ResultAppUserDto>> GetAllAppUserAsync();
        Task CreateAppUserAsync(CreateAppUserDto createAppUserDto);
        Task UpdateAppUserAsync(UpdateAppUserDto updateAppUserDto);
        Task DeleteAppUserAsync(string id);
        Task<GetByIdAppUserDto> GetByIdAppUserAsync(string id);
    }
}
