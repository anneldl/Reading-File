using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LopezCreatingTextFile
{
    public partial class Form3 : Form
    {
        public static String SetFileName;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            


            String getInput = txtboxStudentNo.Text;
            String getProgram = cbProgram.Text;
            String getFirstName = tbFirstName.Text;
            String getLastName = tbLastName.Text;
            String getGender = cbGender.Text;
            String getAge = tbAge.Text;
            String getBirthday = DateTimePicker.Text;
            String getContactNo = tbContactNo.Text;



            String docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, getInput + ".txt")))
            {
                outputFile.WriteLine("Student Number: "+getInput);
                outputFile.WriteLine("Full Name: " + getLastName + " " + getFirstName);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender );
                outputFile.WriteLine("Age: " + getAge );
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Contact No: " + getContactNo);
                Console.WriteLine(getInput);
            }
            Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.ShowDialog();
        }
    }
}
