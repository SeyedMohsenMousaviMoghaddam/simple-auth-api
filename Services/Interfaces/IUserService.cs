using Auth.API.ViewModel.Requests;
using Auth.API.ViewModel.Responses;

namespace Auth.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<TokenResponse> LoginAsync(LoginRequest loginRequest);
        Task<SignupResponse> SignupAsync(SignupRequest signupRequest);
        Task<LogoutResponse> LogoutAsync(int userId);
    }
}
