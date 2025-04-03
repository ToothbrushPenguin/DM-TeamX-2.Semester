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
    public class UserRepository : RepositoryBase, IRepository<User>
    {
        private List<User> users;
        public UserRepository()
        {
            Implement();
            users = new List<User>();
        }
        


        public User Create(User user)
        {
            
            using (SqlConnection con = new SqlConnection(ConnectionStrings))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [CASE] (Name, Email, System, CaseType, Criticality, Description, SystemId) VALUES(@Name, @Email, @System, @CaseType, @Criticality, @Description, " +
                                                       "(SELECT SystemId FROM [SYSTEM] WHERE NAME = @System)) SELECT @@IDENTITY", con))
                {
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = user.Name;
                    cmd.Parameters.Add("@Initials", SqlDbType.NVarChar, 50).Value = user.Initials;
                    
                    users.Add(user);
                }
            }

            return user;
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ReadAll()
        {
            throw new NotImplementedException();
        }

      

        public User Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
