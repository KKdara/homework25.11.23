using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework25._11._23
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DeveloperInfoAttribute1: Attribute
    {
        protected string DeveloperName { get; set; }
        protected string NameOfOrganization { get; set; }
        public DeveloperInfoAttribute1(string developerName, string nameOfOrganization)
        {
            DeveloperName = developerName;
            NameOfOrganization = nameOfOrganization;
        }
    }
}
