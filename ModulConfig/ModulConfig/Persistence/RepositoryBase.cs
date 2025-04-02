using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulConfig.Persistence
{
    public abstract class RepositoryBase
    {
        public string ConnectionString { get; private set; }
        public void Implement()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            ConnectionString = config.GetConnectionString("MyDBConnection");

        }
    }
}
