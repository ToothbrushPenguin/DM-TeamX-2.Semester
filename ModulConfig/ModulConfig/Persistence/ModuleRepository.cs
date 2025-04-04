using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class ModuleRepository : RepositoryBase, IRepository<Module>
    {
        private List<Module> modules;
        private string jsonString;
        private string filePath;
        public ModuleRepository()
        {
            Implement();

        }

        public void Create(Module module)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("spCreateModule", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SerialNumber", SqlDbType.NVarChar, 50).Value = module.SerialNumber;
                    cmd.Parameters.Add("@Model", SqlDbType.NVarChar, 50).Value = module.Model;
                    cmd.Parameters.Add("@Variant", SqlDbType.NVarChar, 50).Value = module.Variant;
                    cmd.Parameters.Add("@InstallationDay", SqlDbType.DateTime).Value = module.InstallationDay.ToDateTime(TimeOnly.MinValue);
                    cmd.Parameters.Add("@KeyID", SqlDbType.NVarChar, 50).Value = module.KeyID;
                    cmd.Parameters.Add("@PublicKey", SqlDbType.NVarChar, 4000).Value = module.PublicKey;
                    cmd.Parameters.Add("@SupportAPIVersion", SqlDbType.NVarChar, 10).Value = module.SupportAPIVersion;

                    cmd.ExecuteNonQuery();
                    modules.Add(module);
                }
            }
        }

        public void Delete(Module module)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteModule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SerialNumber", SqlDbType.NVarChar, 50).Value = module.SerialNumber;
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Module> ReadAll()
        {
            List<Module> result = new List<Module>();
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spGetModules", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime installDate = reader.GetDateTime(3);
                        DateOnly installDateOnly = DateOnly.FromDateTime(installDate);

                        Module module = new Module(
                        
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            installDateOnly,
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(6)
                        );
                        result.Add(module);
                    }
                }
            }
            return result;
        }

        public void Update(Module module)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateModule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SerialNumber", SqlDbType.NVarChar, 50).Value = module.SerialNumber;
                cmd.Parameters.Add("@Model", SqlDbType.NVarChar, 50).Value = module.Model;
                cmd.Parameters.Add("@Variant", SqlDbType.NVarChar, 50).Value = module.Variant;
                cmd.Parameters.Add("@InstallationDay", SqlDbType.DateTime).Value = module.InstallationDay.ToDateTime(TimeOnly.MinValue);
                cmd.Parameters.Add("@KeyID", SqlDbType.NVarChar, 50).Value = module.KeyID;
                cmd.Parameters.Add("@PublicKey", SqlDbType.NVarChar, 4000).Value = module.PublicKey;
                cmd.Parameters.Add("@SupportAPIVersion", SqlDbType.NVarChar, 10).Value = module.SupportAPIVersion;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
