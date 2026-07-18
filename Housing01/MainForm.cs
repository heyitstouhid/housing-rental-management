using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Housing01
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        public MainForm()
        {
            InitializeComponent();
            LoadButtonIcons();
        }

        private void LoadButtonIcons()
        {
            try
            {
                string imagesDir = Path.Combine(Application.StartupPath, "Images");
                SetButtonImage(btnUsers, Path.Combine(imagesDir, "admin2.png"));
                SetButtonImage(btnCategories, Path.Combine(imagesDir, "categoryNew.png"));
                SetButtonImage(btnTenants, Path.Combine(imagesDir, "Tenant.png"));
                SetButtonImage(btnRentals, Path.Combine(imagesDir, "rental1.png"));
                SetButtonImage(btnExit, Path.Combine(imagesDir, "exit2.png"));
            }
            catch
            {
                // Ignore loading errors to avoid crashing the form at startup
            }
        }

        private void SetButtonImage(Button btn, string path)
        {
            if (File.Exists(path) && btn != null)
            {
                try
                {
                    Image img = Image.FromFile(path);
                    btn.Image = img;
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
                catch { }
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
