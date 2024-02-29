using Microsoft.Extensions.Configuration;

namespace AppSettings
{
    internal class Program
    {
        private static void Main()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            var apiSettings = config.GetSection("ApiSettings").Get<ApiSettings>()!;

            Console.WriteLine(apiSettings.ApiKey);
            Console.WriteLine(apiSettings.ApiSecret);
            Console.WriteLine(apiSettings.BearerToken);
        }
    }
}
