using SortBDay.Controller;
using SortBDay.DAL;
using SortBDay.Helper;
using SortBDay.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace React
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private Person s1 = new Person();
        private PersonController controller;

        private void frmMain_Load(object sender, EventArgs e)
        {
            lCurrentDate.Text = DateTime.Now.ToString("dd MMMM yyyy");

            ValidateFileSetup();
            controller = new PersonController(s1);
            LoadPeople();
        }

        private void LoadPeople()
        {

            if (!string.IsNullOrEmpty(FileHelper.FileName))
            {

                var getPeople = controller.GetPeople().Result;

                if (!getPeople.success)
                    MessageBox.Show(getPeople.message);
                else
                {
                    dgvPeople.Rows.Clear();
                    foreach (var item in getPeople.summary.People)
                    {
                        dgvPeople.Rows.Add(item.Id, item.Name, item.Surname, item.PersonDateDescription);
                    }

                    tAverage.Text = getPeople.summary.AgeAverage.ToString();
                }
            }
        }

        private void ValidateFileSetup()
        {
            if (string.IsNullOrEmpty(FileHelper.FileName))
                EnableDisableControl(false);
            else
                EnableDisableControl(true);
            
        }

        private void EnableDisableControl(bool flag)
        {
            bCreate.Enabled = flag;
            bRefresh.Enabled = flag;
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileHelper.FileName = openFileDialog1.FileName;
                tFilePath.Text = FileHelper.FileName;
                ValidateFileSetup();
                LoadPeople();
            }
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            frmCreate form = new frmCreate();
            form.ShowDialog();

            LoadPeople();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            LoadPeople();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
