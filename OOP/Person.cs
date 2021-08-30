using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {


        #region Properties
        public string Name { get;private set; }
        public string Address { get; private set; }
        public int Age { get; private set; }
        public string FathersName { get; private set; }
        public string MothersName { get; private set; }
        #endregion

        #region constructor

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name">using for person name</param>
        /// <param name="address">using for person address</param>
        /// <param name="age">using for person age</param>
        /// <param name="fathersName">using for person father's name</param>
        /// <param name="mothersName">using for person mother's name</param>

        public Person(string name, string address, int age, string fathersName, string mothersName)
        {
            Name = name;
            Address = address;
            Age = age;
            FathersName = fathersName;
            MothersName = mothersName;
        }

        #endregion
    }
}
