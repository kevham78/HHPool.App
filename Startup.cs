using Microsoft.Extensions.Configuration;

namespace HHPool.App
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

    }
}
