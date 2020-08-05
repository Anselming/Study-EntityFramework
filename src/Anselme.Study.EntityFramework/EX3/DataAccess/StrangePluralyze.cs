using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Text.RegularExpressions;
using System.Security.Authentication.ExtendedProtection;

namespace Anselme.Study.EntityFramework.DataAccess.SchoolContext.DataAccess
{
    public class StrangePluralyzeConvention : Convention
    {
        public StrangePluralyzeConvention()
        {
            Types()
                .Where(p => (p.Name.Contains("Strange")))
                .Configure(c => c.ToTable(ChangeProperty(c.ClrType)));
               
        }

        public string ChangeProperty(Type type)       // StrangeEntity (in model) -> StrangeEntitzy (in database)
        {
            string property = type.Name.ToLower();

            //var pluralizationService = DbConfiguration.DependencyResolver.GetService<IPluralizationService>();
            //var result = pluralizationService.Pluralize(type.Name);

            string result = property;
            string strangePattern = "strange([A-z])*y";

            if (Regex.Match(property, strangePattern).Success)
            {
                // Is strange
                int strangeIndex = property.IndexOf("strange");
                int strangeIndexLenght = "strange".Length;
                int propertyLenght = property.Length;
                string strangePart = property.Substring(strangeIndexLenght, propertyLenght- strangeIndexLenght);

                // Last is Y
                if(strangePart[strangePart.Length-1] == 'y')
                {
                    string strangeModified = strangePart.Remove(strangePart.Length-1);
                    strangeModified = $"strange{strangeModified}zy";

                    result = strangeModified;
                }
            }

            return result.ToLower();
        }
    }
}
