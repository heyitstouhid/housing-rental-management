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
    public partial class SelectCategory : Form
    {
        public string CategoryID { set; get; }
        public SelectCategory()
        {
            InitializeComponent();
        }

        private void SelectCategory_Load(object sender, EventArgs e)
        {
            this.cmbCondition.Items.Clear();
            this.cmbCondition.Items.Add("CategoryName");
            this.cmbCondition.Items.Add("Remark");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sqlStr = string.Format("select * from HouseCategory");//Default is to query all Category info.
            if (this.cmbCondition.SelectedIndex == 0) //Perform fuzzy query based on the CategoryName field
            {
                sqlStr = string.Format("select * from HouseCategory where CategoryName like '%{0}%'", this.tbValue.Text);
            }
            if (this.cmbCondition.SelectedIndex == 1) //Perform fuzzy query based on the Remark field
            {
                sqlStr = string.Format("select * from HouseCategory where Remark like '%{0}%'", this.tbValue.Text);
            }
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            this.dgvCategoryList.DataSource = ds1.Tables[0];
            this.SetDgvWidth();
        }
        private void SetDgvWidth() //Set the width of each column in the dgvUserList
        {
            this.dgvCategoryList.Columns[0].Width = 60;  //Set the width of the first column
            this.dgvCategoryList.Columns[1].Width = 120;
            this.dgvCategoryList.Columns[2].Width = 480;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.CategoryID==null)
            {
                MessageBox.Show("Please select one record.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.DialogResult = DialogResult.OK;//return a value
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;//The return value is not needed.
            this.Close();
        }

        private void dgvCategoryList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {            
            this.CategoryID = this.dgvCategoryList.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(this.CategoryID.ToString()+ "        "+e.RowIndex.ToString());
        }
    }
}
