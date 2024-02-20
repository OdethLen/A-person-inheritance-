using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_person
{
    internal class Person
    {
		//Properties
		protected string name; //Field

		public string Name //Prop
		{
			get { return name; }
			set { name = value; }
		}

		protected string last_name;

		public string Last_name
		{
			get { return last_name; }
			set { last_name = value; }
		}

		protected int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		private string gender;

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		//Constructor
		public Person ()
		{
			name = "";
			last_name = "";
			age = 0;
			gender = "";//string.Empty; 

		}

		//Methods 
		public void Personinformation (string Name, string Last_name, int Age, string Gender )
		{
			name = Name;
			this.name = Name;
			last_name = Last_name;
			this.last_name = Last_name;
			age = Age;
			this.age=Age;
			gender = Gender;
			this.gender = Gender;
		}


		public void Speak ()
		{
			Console.WriteLine("Hello!!"+" I´m "+ name +",Nice to meet you :D");
		}


	}
}
