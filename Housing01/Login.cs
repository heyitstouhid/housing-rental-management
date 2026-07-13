using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccess;

namespace Housing01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sqlStr = string.Format("select * from Admin where LoginName = '{0}' and LoginPwd = '{1}'", this.tbUserName.Text, this.tbPwd.Text);
            DataSet ds = new DataSet();
            ds = SQLHelper.GetData(sqlStr);
            if (ds.Tables[0]!=null && ds.Tables[0].Rows.Count > 0)
            {
                this.Hide();
                MainForm mForm = new MainForm();
                mForm.Show();
            }
            else
            {
                MessageBox.Show("The user info is error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
