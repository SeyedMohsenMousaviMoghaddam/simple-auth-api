namespace Auth.API.ViewModel.Responses
{
    public class TokenResponse : BaseResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

    }
}
