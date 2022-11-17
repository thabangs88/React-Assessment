using SortBDay.Controller;
using SortBDay.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortBDay.Views
{
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            var createPerson = controller.CreatePerson(new Model.PersonModel()
            {
                Name = tFirstname.Text,
                DateofBirth = Convert.ToDateTime(dtDOB.Text),
                Surname = tSurname.Text
            }).Result;

            MessageBox.Show(createPerson.message);

            if (createPerson.success)
                this.Close();

        }
        
        private Person s1 = new Person();
        private PersonController controller;

        private void frmCreate_Load(object sender, EventArgs e)
        {
            controller = new PersonController(s1);

        }
    }
}
