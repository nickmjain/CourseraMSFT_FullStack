using Microsoft.Extensions.Configuration;

public class ApiService
{
    private readonly IConfiguration _configuration;

    // Construction: Inject IConfig to access appsettings
    public ApiService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    // Method: ACcess the BaseUrl from appsettings.Development.json
    public string GetApiURL()
    {
        return _configuration["ApiSettings:BaseUrl"];
    }

}