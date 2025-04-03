using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Data.SqlClient;
using ModulConfig.Models;
using Microsoft.Extensions.Configuration;


namespace ModulConfig.Persistence
{
    public class UserRepository : RepositoryBase, IRepository<User>
    {
        private List<User> users;
        public UserRepository()
        {
            Implement();
            users = new List<User>();
        }



        public void Create(User user)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("spCreateUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Initials", SqlDbType.NVarChar, 10).Value = user.Initials;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = user.Name;

                    cmd.ExecuteNonQuery();
                    users.Add(user);
                }
            }
        }

        public void Delete(User user)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Initials", user.Initials);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> ReadAll()
        {
            List<User> result = new List<User>();
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spGetUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User(reader.GetString(1), reader.GetString(0));
                        result.Add(user);
                    }
                }
            }
            return result;
        }



        public void Update(User user)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Initials", SqlDbType.NVarChar).Value = user.Initials;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
