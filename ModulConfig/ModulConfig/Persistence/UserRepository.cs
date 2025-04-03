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
                using (SqlCommand cmd = new SqlCommand($"Execute spCreateUser @Initials, @Name", con))
                {
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = user.Name;
                    cmd.Parameters.Add("@Initials", SqlDbType.NVarChar, 10).Value = user.Initials;
                    
                    users.Add(user);
                }
            }
            
        }

        public void Delete(User user)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Execute spDeleteUser @Initials", con);
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
                SqlCommand cmd = new SqlCommand("Execute spGetUsers", con);
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(reader.GetInt32(0))
                            {
                                Name = reader.GetString(1),
                                Initials = reader.GetString(2)
                            };
                            result.Add(user);
                        }
                    }
                }
            }
            return result;
        }

      

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
