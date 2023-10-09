using Auth.API.Models;
using Auth.API.ViewModel.Requests;
using Auth.API.ViewModel.Responses;

namespace Auth.API.Services.Interfaces
{
    public interface ITokenService
    {
        Task<Tuple<string, string>> GenerateTokensAsync(int userId);
        Task<ValidateRefreshTokenResponse> ValidateRefreshTokenAsync(RefreshTokenRequest refreshTokenRequest);
        Task<bool> RemoveRefreshTokenAsync(User user);
    }
}
