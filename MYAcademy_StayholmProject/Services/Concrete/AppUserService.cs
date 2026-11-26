using MYAcademy_StayholmProject.Dtos.AppUserDtos;
using MYAcademy_StayholmProject.Services.Abstract;

namespace MYAcademy_StayholmProject.Services.Concrete
{
    public class AppUserService : IAppUserService
    {
        public Task CreateAppUserAsync(CreateAppUserDto createAppUserDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAppUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultAppUserDto>> GetAllAppUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdAppUserDto> GetByIdAppUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAppUserAsync(UpdateAppUserDto updateAppUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
