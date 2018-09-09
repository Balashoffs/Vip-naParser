using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VipassanaParser
{
    public partial class MainForm : Form
    {
        FilePcocessor filePcocessor;
        StudentInfo studentInfo;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filePcocessor = new FilePcocessor();
            studentInfo = new StudentInfo();
            FillCheckBoxLists();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenHtml_Click(object sender, EventArgs e)
        {
            OpenHtmlFile();
        }












        private void FillCheckBoxLists()
        {
            checkedListBoxGender.Items.AddRange(studentInfo.GetStudentGender());
            checkedListBoxStudentInfo.Items.AddRange(studentInfo.GetStudentInfo());
            checkedListBoxStudentType.Items.AddRange(studentInfo.GetStudentType());
        }

        private void OpenHtmlFile()
        {
            if (openFileDialogOpenHtml.ShowDialog() == DialogResult.OK)
            {
                filePcocessor.PathToFile = openFileDialogOpenHtml.FileName;
                labelFilePath.Text = filePcocessor.PathToFile;
            }
            else
            {
                filePcocessor.PathToFile = "";
                labelFilePath.Text = "File isn't found";
            }
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
