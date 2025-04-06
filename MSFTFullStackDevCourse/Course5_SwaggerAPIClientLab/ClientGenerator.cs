using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using NSwag;
using NSwag.CodeGeneration.CSharp;

namespace Course5_SwaggerAPIClientLab
{
    public class ClientGenerator
    {
        public async Task GenerateClient()
        {
            using var httpClient = new HttpClient();
            var swaggerJson = await httpClient.GetStringAsync("https://localhost:5000/swagger/v1/swagger.json");
            var document = await NSwag.OpenApiDocument.FromJsonAsync(swaggerJson);

            var settings = new CSharpClientGeneratorSettings
            {
                ClassName = "OctoberAPIClient",
                CSharpGeneratorSettings = { Namespace = "MyClientNamespace" },
            };
            var generator = new CSharpClientGenerator(document, settings);
            var code = generator.GenerateFile();

            await File.WriteAllTextAsync("GeneratedApiClient.cs", code);
        }
    }
}
