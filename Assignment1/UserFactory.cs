using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class UserFactory
    {
        public static IUserpermission CreateUser(string userType)
        {
            return userType switch
            {
                "Student" => new Student(),
                "Teacher" => new Teacher(),
                "Librarian" => new Librarian(),
                _ => throw new ArgumentException("Invalid user type.")
            };
        }
    }

}
