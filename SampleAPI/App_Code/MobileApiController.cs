using System.Collections.Generic;
using System.Web.Http;

public class MobileApiController : ApiController
{
    [HttpGet]
    public bool IsValid()
    {
        return true;
    }

    [HttpPost]
    public LoginResponseModel Login(LoginViewModel loginDetail)
    {
        return new LoginResponseModel() { IsSuccess = true, Token = "asdasd", ValidationMessage = string.Empty };
    }

    [HttpGet]
    public List<dynamic> GetNotifications(string token)
    {
        return new List<dynamic> { new { Title = "", Message = "", Id = 1 } };
    }

    [HttpPost]
    public bool MarkNotificationAsRead(int notificationId)
    {
        return true;
    }

    [HttpGet]
    public bool ForgotPassword(string email)
    {
        return true;
    }
}

public class LoginViewModel
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }
    public string FirebaseToken { get; set; }
    public string MacAddress { get; set; }
}

public class LoginResponseModel
{
    public bool IsSuccess { get; set; }
    public string Token { get; set; }
    public string ValidationMessage { get; set; }
}