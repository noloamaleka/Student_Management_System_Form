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
    public partial class Display : Form
    {
        //public List<Degree> DegreesList { get; set; }
        //public List<Diploma> diplomasList { get; set; } 
        public Display()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show(this);
        }

        private void Display_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDegree_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = "";
            dgvStudents.DataSource = DataContainer.DegreeList;
            ColumnNames(dgvStudents);
        }

        private void btnDiploma_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = "";
            dgvStudents.DataSource = DataContainer.DiplomaList;
            ColumnNames(dgvStudents);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = "";
            DataTable table = new DataTable();
            DataColumn Col;

            Col = new DataColumn();
            Col.DataType = typeof(string);
            Col.ColumnName = "StudentID";
            table.Columns.Add(Col);

            Col = new DataColumn();
            Col.DataType = typeof(string);
            Col.ColumnName = "Name";
            table.Columns.Add(Col);

            Col = new DataColumn();
            Col.DataType = typeof(string);
            Col.ColumnName = "Surname";
            table.Columns.Add(Col);

            Col = new DataColumn();
            Col.DataType = typeof(string);
            Col.ColumnName = "Gender";
            table.Columns.Add(Col);

            Col = new DataColumn();
            Col.DataType = typeof(string);
            Col.ColumnName = "E-Mail";
            table.Columns.Add(Col);

            Col = new DataColumn();
            Col.DataType = typeof(string);
            Col.ColumnName = "Phone Number";
            table.Columns.Add(Col);

            Col = new DataColumn();
            Col.DataType = typeof(string);
            Col.ColumnName = "Qualification";
            table.Columns.Add(Col);

            Col = new DataColumn();
            Col.DataType = typeof(int);
            Col.ColumnName = "Age";
            table.Columns.Add(Col);

            Col = new DataColumn();
            Col.DataType = typeof(DateTime);
            Col.ColumnName = "Date of Birth";
            table.Columns.Add(Col);

            Col = new DataColumn();
            Col.DataType = typeof(double);
            Col.ColumnName = "Discount";
            table.Columns.Add(Col);

            Col = new DataColumn();
            Col.DataType = typeof(double);
            Col.ColumnName = "Fees";
            table.Columns.Add(Col);

            table.AcceptChanges();

            int TotalLength = DataContainer.DegreeList.Count + DataContainer.DiplomaList.Count;
            int DegLength = DataContainer.DegreeList.Count;
            //string[,] all = new string[TotalLength, 11];
            for (int i = 0; i < TotalLength; i++)
            {
                if (i < DegLength)
                {
                    DataRow row = table.NewRow();
                    row["StudentID"] = DataContainer.DegreeList[i].StudentID1;
                    row["Name"] = DataContainer.DegreeList[i].Name1;
                    row["Surname"] = DataContainer.DegreeList[i].Surname1;
                    row["Gender"] = DataContainer.DegreeList[i].Gender1;
                    row["E-Mail"] = DataContainer.DegreeList[i].Email1;
                    row["Phone Number"] = DataContainer.DegreeList[i].PhoneNum1;
                    row["Qualification"] = DataContainer.DegreeList[i].Qualification1;
                    row["Age"] = DataContainer.DegreeList[i].Age;
                    row["Date of Birth"] = DataContainer.DegreeList[i].Dob1;
                    row["Discount"] = DataContainer.DegreeList[i].Degdiscount1;
                    row["Fees"] = DataContainer.DegreeList[i].Degfee1;


                    table.Rows.Add(row);
                    table.AcceptChanges();

                }
                else
                {
                    DataRow row = table.NewRow();
                    row["StudentID"] = DataContainer.DiplomaList[i - DegLength].StudentID1;
                    row["Name"] = DataContainer.DiplomaList[i - DegLength].Name1;
                    row["Surname"] = DataContainer.DiplomaList[i - DegLength].Surname1;
                    row["Gender"] = DataContainer.DiplomaList[i - DegLength].Gender1;
                    row["E-Mail"] = DataContainer.DiplomaList[i - DegLength].Email1;
                    row["Phone Number"] = DataContainer.DiplomaList[i - DegLength].PhoneNum1;
                    row["Qualification"] = DataContainer.DiplomaList[i - DegLength].Qualification1;
                    row["Age"] = DataContainer.DiplomaList[i - DegLength].Age;
                    row["Date of Birth"] = DataContainer.DegreeList[i - DegLength].Dob1;
                    row["Discount"] = DataContainer.DiplomaList[i - DegLength].DipDiscount1.ToString();
                    row["Fees"] = DataContainer.DiplomaList[i - DegLength].DipFee1.ToString();

                    table.Rows.Add(row);
                    table.AcceptChanges();
                }
            }
            //dgvStudents.DataSource = all;
            dgvStudents.DataSource = table;
        }
        static void ColumnNames(DataGridView dgvViews)
        {
            dgvViews.Columns[0].HeaderCell.Value = "Fees";
            dgvViews.Columns[1].HeaderCell.Value = "Discount";
            dgvViews.Columns[2].HeaderCell.Value = "StudentID";
            dgvViews.Columns[3].HeaderCell.Value = "Name";
            dgvViews.Columns[4].HeaderCell.Value = "Surname";
            dgvViews.Columns[5].HeaderCell.Value = "Gender";
            dgvViews.Columns[6].HeaderCell.Value = "E-Mail";
            dgvViews.Columns[7].HeaderCell.Value = "Phone Number";
            dgvViews.Columns[8].HeaderCell.Value = "Qualification";
            dgvViews.Columns[9].HeaderCell.Value = "Age";
            dgvViews.Columns[10].HeaderCell.Value = "Date of Birth";
        }   
    }
}
