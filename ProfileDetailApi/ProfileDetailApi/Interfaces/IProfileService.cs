using ProfileDetailApi.DTOs;

namespace ProfileDetailApi.Interfaces
{
   
    public interface IProfileService
    {
        Task<ProfileDto> GetProfileAsync();
    }
}
