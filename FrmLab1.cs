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
    public partial class FrmLab1 : Form
    {
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName FrmFileName = new FrmFileName();
            FrmFileName.ShowDialog();

            String getInput = txtInput.Text;
         

            String docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile  = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

        }      
        
        
        public FrmLab1()
        {
            InitializeComponent();
        }
    }
}
