using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Person
    {
        private string name;

        public Person(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "You have to put a name");
            }
            else
            {
                this.name = name;
            }
        }
        public string Name { get; set; }

        public string toString()
        {
            string result = "The name is : " + this.name;
            return result;
        }
        ~Person()
        {
            name = String.Empty;
        }
    }
}
