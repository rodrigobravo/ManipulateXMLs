using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManipulateXMLs;

namespace ManipulateXMLs
{
    public partial class Form1 : Form
    {
        public int filesCount = 0;
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
                    string xmlDate = XMLParsing.DateParsing(file);
                    //foreach (string dtEmit in xmlDate)
                    // {
                    if (xmlDate != "")
                    {
                        lstFolders.Items.Clear();
                        lstFolders.Items.Add(xmlDate);
                        filesCount = lstFolders.Items.Count;
                        lblSelectedFolder.Text = "Pasta selecionada: " + folderBrowserDialog1.SelectedPath.ToString();
                    }
                    // }
                }

                pnlDateSel.Visible = true;
            }
        }

        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("Data inicio: " + dtStart.Value + " Data fim: " + dtEnd.Value);
            lstFolders.Visible = true; //Show files listS
            txtTotalCount.Text = filesCount.ToString();
        }

        private void btnDateFilter_Click_1(object sender, EventArgs e)
        {
            Trace.WriteLine("Data inicio: " + dtStart.Value + " Data fim: " + dtEnd.Value);
            lstFolders.Visible = true; //Show files listS
            txtTotalCount.Text = filesCount.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
