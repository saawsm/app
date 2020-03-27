using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saawsm.App {

    public static class StringUtil {


        public static string GetFullName(string firstName, string lastName) {
            if (firstName == null)
                throw new ArgumentNullException(nameof(firstName));
            if (lastName == null)
                throw new ArgumentNullException(nameof(lastName));
          
            return $"{firstName.Trim()} {lastName.Trim()}";
        }


    }
}
