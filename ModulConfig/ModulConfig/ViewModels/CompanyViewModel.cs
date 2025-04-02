using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModulConfig.Models;

namespace ModulConfig.ViewModels
{
    internal class CompanyViewModel
    {
        private Company company;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        public CompanyViewModel(Company company)
        {
            this.company = company;

            Name = company.Name;
            Email = company.Email;
            Contact = company.Contact;
        }
    }
}
