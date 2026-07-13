using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing01
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void tsBtnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm());
        }

        private void tsBtnTenantManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TenantForm());
        }

        private void tsBtnCatrgoryManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryForm());
        }

        private void tsBtnHouseManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HouseForm());
        }

        private void tsBtnRentalManage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RentlForm());
        }

        private void tsBtnCheckOut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CheckoutForm());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                try
                {
                    activeForm.Close();
                }
                catch { }
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
