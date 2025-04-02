using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace ModulConfig.Persistence
{
    public abstract class RepositoryBase
    {
        public string ConnectionStrings { get; private set; }
        public void Implement()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            ConnectionStrings = config.GetConnectionString("MyDBConnection");

        }
    }
}
