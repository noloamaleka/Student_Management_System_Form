using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_261_Project
{
    public class Degree : Student
    {
        private double Degfee = 85000.00, Degdiscount;
        public Degree(string studentID, string name, string surname, string gender, string email, string phoneNum, string qualification, int age, DateTime dob, double Degdiscount) : base(studentID, name, surname, gender, email, phoneNum, qualification, age, dob)
        {
            this.Degdiscount1 = Degdiscount;
        }

        public double Degfee1 { get => Degfee; set => Degfee = value; }
        public double Degdiscount1 { get => Degdiscount; set => Degdiscount = value; }

        public override void Discount()
        {
            Degfee = Degfee * Degdiscount;
        }

    }
}
