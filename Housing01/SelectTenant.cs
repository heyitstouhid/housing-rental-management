using DataAccess;
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
    public partial class SelectTenant : Form
    {
        public string TenantID { get; set; }
        public SelectTenant()
        {
            InitializeComponent();
        }


        private void SelectTenant_Load(object sender, EventArgs e)
        {

            //set the query condition and default is to query all house info.
            this.cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCondition.Items.Clear();
            this.cmbCondition.Items.Add("RealName");
            this.cmbCondition.Items.Add("Phone");
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sqlStr = string.Format("select * from TenantInfo");//Default is to query all Tenant info.
            if (this.cmbCondition.SelectedIndex == 0) //Retrieve all Tenant info based on RealName.
            {
                sqlStr = string.Format("select * from TenantInfo where RealName like '%{0}%'",this.tbValue.Text);
            }
            if (this.cmbCondition.SelectedIndex == 1) //Perform fuzzy query based on the Phone field
            {
                sqlStr = string.Format("select * from TenantInfo where Phone like '%{0}%'", this.tbValue.Text);
            }
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            this.dgvTenantList.DataSource = ds1.Tables[0];
            this.SetDgvWidth();
        }
        private void SetDgvWidth() //Set the width of each column in the dgvTenantList
        {
            this.dgvTenantList.Columns[0].Width = 60;  //Set the width of the first column
            this.dgvTenantList.Columns[1].Width = 60;
            this.dgvTenantList.Columns[2].Width = 150;
            this.dgvTenantList.Columns[3].Width = 30;
            this.dgvTenantList.Columns[4].Width = 30;
        }

        private void dgvTenantList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Obtain the index of the selected row
            int n = this.dgvTenantList.CurrentRow.Index;
            this.TenantID = this.dgvTenantList[0, n].Value.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;//return a value
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;//The return value is not needed
            this.Close();
        }
    }
}
