using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_261_Project
{
    public partial class RegisterForm : Form
    {
        Promotion Promotion = new Promotion();
        //public List<Degree> DegreeList = new List<Degree>();
        //public List<Diploma> DiplomaList = new List<Diploma>();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBackRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show(this);
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Name, ID, Surname, Gender, Email, PhoneNumber, Qualification;
            int age;
            DateTime DOB;
            Name = txtName.Text;
            Surname = txtSurname.Text;
            ID = txtID.Text;
            Gender = (string)cbxGender.SelectedItem;
            Email = txtEmail.Text;
            PhoneNumber = txtPhoneNumber.Text;
            DOB = dtpDOB.Value;
            age = DateTime.Now.Year - DOB.Year;
            if (rbnDegree.Checked == true && rbnDiploma.Checked == false)
            {
                Qualification = "Degree";
                double discount = Promotion.DiscountPercentage(age, Gender);
                if(discount == 0.7)
                {
                    MessageBox.Show("Sucessful submission! You just recived a 30% discount!");
                }
                else if (discount == 0.81)
                {
                    MessageBox.Show("Sucessful submission! You just recived a 19% discount!");
                }
                else
                {
                    MessageBox.Show("Sucessful submission!");
                }
                Degree degree = new Degree(ID, Name, Surname, Gender, Email, PhoneNumber, Qualification,
                    age, DOB, discount);
                degree.Discount();
                DataContainer.DegreeList.Add(degree);   
            }
            else if (rbnDegree.Checked == false && rbnDiploma.Checked == true)
            {
                Qualification = "Diploma";
                double discount = Promotion.DiscountPercentage(age, Gender);
                if (discount == 0.7)
                {
                    MessageBox.Show("Sucessful submission! You just recived a 30% discount!");
                }
                else if (discount == 0.81)
                {
                    MessageBox.Show("Sucessful submission! You just recived a 19% discount!");
                }
                else
                {
                    MessageBox.Show("Sucessful submission!");
                }
                Diploma diploma = new Diploma(ID, Name, Surname, Gender, Email, PhoneNumber, Qualification,
                    age, DOB, discount);
                diploma.Discount(); 
                DataContainer.DiplomaList.Add(diploma);
            }
            
        }
    }
}
