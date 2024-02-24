
namespace A_person  
    {
        class Program
        { 
        static void Main(string[] args) 
            {

            Person person_one=new Person();
            person_one.Personinformation("Perseus","Jackson",18,"Male");
            Console.WriteLine("\nName:" + person_one.Name + "\nLast name:" + person_one.Last_name + "\nAge:" + person_one.Age + "\nGender:" + person_one.Gender);
            person_one.Speak();

            Student student_one =new Student();
            student_one.Personinformation("Harry","Potter",18,"Male");
            student_one.StudentInformation("G911980","Hogwarts");
            Console.WriteLine("\nName:" + student_one.Name + "\nLast name:" + student_one.Last_name + "\nAge:" + student_one.Age + "\nGender:" + student_one.Gender + "\nEnrollment:" + student_one.Enrollment + "\nSchool:"+ student_one.School_name);
            student_one.Speak();
        }
        }
    }
