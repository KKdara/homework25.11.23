using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework25._11._23
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DeveloperInfoAttribute: Attribute
    {
        protected string DeveloperName {  get; set; }
     
        protected DateTime DateOfDevelopment {  get; set; }
       
        public DeveloperInfoAttribute(string developerName, string date)
        {
            DeveloperName = developerName;
            DateOfDevelopment.ToString(); 
            DeveloperName = date;
        }
    }
}
