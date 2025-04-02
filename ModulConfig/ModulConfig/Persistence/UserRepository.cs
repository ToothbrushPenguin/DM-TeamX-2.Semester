using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class UserRepository : RepositoryBase, IRepository<User>
    {
        public UserRepository()
        {
            Implement();
            users = new List<User>();
        }
        private List<User> users;


        public User Create(params object[] parameters)
        {
            if (parameters.Length < 2)
                throw new ArgumentException("Not enough parameters. Expected: name, initials");

            string name = parameters[0] as string;
            string initials = parameters[1] as string;

            if (name == null || initials == null)
                throw new ArgumentException("Invalid parameter types. Expected: string, string");

            User user = new User(name, initials);


            using (SqlConnection con = new SqlConnection(ConnectionString))
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

        public void Delete(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User Read(params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public User Update(params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
