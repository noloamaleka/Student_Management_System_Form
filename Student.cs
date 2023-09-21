using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_261_Project
{
    public class Student
    {
        private string StudentID, Name, Surname, Gender, Email, PhoneNum, Qualification;
        private int age;
        private DateTime Dob;

        public Student(string studentID, string name, string surname, string gender, string email, string phoneNum, string qualification, int age, DateTime dob)
        {
            StudentID1 = studentID;
            Name1 = name;
            Surname1 = surname;
            Gender1 = gender;
            Email1 = email;
            PhoneNum1 = phoneNum;
            Qualification1 = qualification;
            this.Age = age;
            Dob1 = dob;
        }

        public string StudentID1 { get => StudentID; set => StudentID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string PhoneNum1 { get => PhoneNum; set => PhoneNum = value; }
        public string Qualification1 { get => Qualification; set => Qualification = value; }
        public int Age { get => age; set => age = value; }
        public DateTime Dob1 { get => Dob; set => Dob = value; }


        public virtual void Discount()
        {

        }
    }
}
