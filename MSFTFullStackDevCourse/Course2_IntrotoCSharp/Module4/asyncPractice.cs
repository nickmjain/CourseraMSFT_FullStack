using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2_IntrotoCSharp.Module4
{
    class asyncPractice
    {
        public async Task ReadFileAsync(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = await reader.ReadToEndAsync(); // Simulate download for 5 seconds
                Console.WriteLine(content);
            }
        }

        public async Task SimulateDelayAsync()
        {
            Console.WriteLine("Operation started...");
            await Task.Delay(50000); // 5 second delay to simulate a time-consuming operation
            Console.WriteLine("Operation complete");
        }

        public async Task RunAsync(string filePath)
        {
            await ReadFileAsync(filePath);
            await SimulateDelayAsync();
        }
    }
}
