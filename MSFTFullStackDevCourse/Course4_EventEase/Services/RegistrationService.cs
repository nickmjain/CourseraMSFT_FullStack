using Course4_EventEase.Models;

namespace Course4_EventEase.Services
{
    public class RegistrationService : IRegistrationService
    {
        private List<RegistrationModel> registrations = new List<RegistrationModel>();

        public async Task<bool> RegisterUser(RegistrationModel model)
        {
            registrations.Add(model);
            return await Task.FromResult(true); // Simulate success
        }
    }
}
