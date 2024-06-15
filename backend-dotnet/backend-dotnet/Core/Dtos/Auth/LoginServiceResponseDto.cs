namespace backend_dotnet.Core.Dtos.Auth
{
    public class LoginServiceResponseDto
    {
        public string NewToken { get; set; }

        // this would return data to frontend
        public UserInfoResult UserInfo { get; set;}
    }
}
