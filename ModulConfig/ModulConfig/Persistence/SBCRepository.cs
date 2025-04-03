using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class SBCRepository : RepositoryBase, IRepository<SBC>
    {
        private List<SBC> sbcs;
        public SBCRepository()
        {
            Implement();
            sbcs = new List<SBC>();
        }

        public void Create(SBC sbc)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("spCreateSBC", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SBCSerialNumber", SqlDbType.NVarChar, 50).Value = sbc.SBCSerialNumber;
                    cmd.Parameters.Add("@Model", SqlDbType.NVarChar, 50).Value = sbc.Model;

                    cmd.ExecuteNonQuery();
                    sbcs.Add(sbc);
                }
            }
        }

        public void Delete(SBC sbc)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteSBC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SBCSerialNumber", SqlDbType.NVarChar, 50).Value = sbc.SBCSerialNumber;
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<SBC> ReadAll()
        {
            List<SBC> result = new List<SBC>();
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spGetSBCs", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SBC sbc = new SBC(
                            reader.GetString(1),
                            reader.GetString(0)  
                        );
                        result.Add(sbc);
                    }
                }
            }
            return result;
        }

        public void Update(SBC sbc)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateSBC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SBCSerialNumber", SqlDbType.NVarChar, 50).Value = sbc.SBCSerialNumber;
                cmd.Parameters.Add("@Model", SqlDbType.NVarChar, 50).Value = sbc.Model;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
