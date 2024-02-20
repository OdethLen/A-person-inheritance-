using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_person
{
    internal class Student: Person
    {
		//Propeties
		private string enrollment;

        public string Enrollment
		{
			get { return enrollment; }
			set { enrollment = value; }
		}

		private string school_name;

		public string School_name
		{
			get { return school_name; }
			set { school_name = value; }
		}


		//Constructor
		public Student() 
		{
			enrollment = "";
			school_name = "";
		}

        //Methods 
        public void StudentInformation (string Enrollment, string School_name)
        {
            enrollment = Enrollment;
            this.enrollment = Enrollment;

            school_name = School_name;
            this.school_name = School_name;

        }

    }
}
