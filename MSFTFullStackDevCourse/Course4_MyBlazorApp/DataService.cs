using System.Collections.Generic;
using System.Threading.Tasks;
    
namespace Course4_MyBlazorApp
{
    public class DataService
    {
        public async Task<List<string>> GetProductAsync()
        {
            await Task.Delay(500); // Simulate a delay rfom an API call
            return new List<string> {
                "Product 1",
                "Product 2",
                "Product 3"
            };
        }
    }
}
