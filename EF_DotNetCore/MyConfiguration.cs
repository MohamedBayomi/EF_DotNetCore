using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace EF_DotNetCore
{
    class MyConfiguration : IConfiguration
    {
        public static IConfiguration Configuration;
        public MyConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }
        public string this[string key] { get => Configuration[key]; set => Configuration[key] = value; }
        public IEnumerable<IConfigurationSection> GetChildren() => Configuration.GetChildren();
        public IChangeToken GetReloadToken() => Configuration.GetReloadToken();
        public IConfigurationSection GetSection(string key) => Configuration.GetSection(key);
    }
}
