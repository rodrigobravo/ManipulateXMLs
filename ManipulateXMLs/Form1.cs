using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulateXMLs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ChooseFolder();

        }
        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lstFolders.Text = folderBrowserDialog1.SelectedPath;
                DirectoryInfo dinfo = new DirectoryInfo(lstFolders.Text);
                FileInfo[] Files = dinfo.GetFiles("*.xml");
                foreach (FileInfo file in Files)
                {
                    lstFolders.Items.Add(file.Name);
                }


                lstFolders.Visible = true; //Show files listS
                txtTotalCount.Text = Files.Length.ToString();
            }
        }
    }
}
