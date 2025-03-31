using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.Persistence
{
    public class CompanyRepository : IRepository<Company>
    {
        private List<Company> companies;

        public Company Create(params object[] parameters)
        {
            if (parameters.Length < 3)
                throw new ArgumentException("Not enough parameters. Expected: name, email, contact");

            string name = parameters[0] as string;
            string email = parameters[1] as string;
            string contact = parameters[2] as string;

            if (name == null || email == null || contact == null)
                throw new ArgumentException("Invalid parameter types. Expected: string, string, string");

            Company company = new Company(name, email, contact);

            companies.Add(company);
            return company;
        }

        public void Delete(params object[] parameters)
        {
            if (parameters.Length < 1)
                throw new ArgumentException("Not enough parameters. Expected: name");

            string name = parameters[0] as string;

            if (name == null)
                throw new ArgumentException("Invalid parameter type. Expected: string");

            Company company = companies.FirstOrDefault(c => c.Name == name);
            if (company != null)
            {
                companies.Remove(company);
            }
        }

        public IEnumerable<Company> GetAll()
        {
            return companies;
        }

        public Company Read(params object[] parameters)
        {
            if (parameters.Length < 1)
                throw new ArgumentException("Not enough parameters. Expected: name");

            string name = parameters[0] as string;

            if (name == null)
                throw new ArgumentException("Invalid parameter type. Expected: string");

            return companies.FirstOrDefault(c => c.Name == name);
        }

        public Company Update(params object[] parameters)
        {
            if (parameters.Length < 4)
                throw new ArgumentException("Not enough parameters. Expected: name, newEmail, newContact, newName");

            string name = parameters[0] as string;
            string newEmail = parameters[1] as string;
            string newContact = parameters[2] as string;
            string newName = parameters[3] as string;

            if (name == null || newEmail == null || newContact == null || newName == null)
                throw new ArgumentException("Invalid parameter types. Expected: string, string, string, string");

            Company company = companies.FirstOrDefault(c => c.Name == name);
            if (company != null)
            {
                company.Email = newEmail;
                company.Contact = newContact;
                company.Name = newName;
            }

            return company;
        }
    }
}

