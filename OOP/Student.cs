using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student : Person
    {
        #region Properties
        public int Roll { get; private set; }
        public int Class { get; private set; }
        public string Section { get; private set; }
        #endregion
        

        #region construct

        /// <summary>
        /// it's a constructior,and calling base constructor
        /// </summary>
        /// <param name="name">using for person name</param>
        /// <param name="address"> using for person address </param>
        /// <param name="age">using for person address</param>
        /// <param name="fathersName">using for person father's name</param>
        /// <param name="mothersName">using for person mother's name</param>
        /// <param name="roll">using for student roll</param>
        /// <param name="Class">using for student class</param>
        /// <param name="section">using for student section</param>

        public Student(string name, string address, int age, string fathersName, string mothersName, int roll, int Class, string section) 
        : base(name, address, age, fathersName, mothersName)
        {
            Roll = roll;
            this.Class = Class;
            Section = section;
        }

        #endregion
    }
}
