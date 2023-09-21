using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_261_Project
{
    public class Diploma : Student
    {
        private double DipFee = 45000.00, DipDiscount;
        public Diploma(string studentID, string name, string surname, string gender, string email, string phoneNum, string qualification, int age, DateTime dob, double DipDiscount) : base(studentID, name, surname, gender, email, phoneNum, qualification, age, dob)
        {
            this.DipDiscount1 = DipDiscount;
        }

        public double DipFee1 { get => DipFee; set => DipFee = value; }
        public double DipDiscount1 { get => DipDiscount; set => DipDiscount = value; }

        public override void Discount()
        {
            DipFee = DipFee*DipDiscount;
        }
    }
}
