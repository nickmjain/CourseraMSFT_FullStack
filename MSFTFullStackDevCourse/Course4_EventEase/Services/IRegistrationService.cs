using Course4_EventEase.Models;

namespace Course4_EventEase.Services
{
    public interface IRegistrationService
    {
        Task<bool> RegisterUser(RegistrationModel model);
    }
}
