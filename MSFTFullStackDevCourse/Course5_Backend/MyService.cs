using System;
using Course5_Backend.Services;

namespace Course5_Backend.Services
{
    public class MyService : IMyService
    {
        private readonly int _serviceId;
        public MyService()
        {
            _serviceId = new Random().Next(100000, 999999);
        }

        public void LogCreation(string message)
        {
            Console.WriteLine($"{message} - Service ID: {_serviceId}");
        }
    }
}
