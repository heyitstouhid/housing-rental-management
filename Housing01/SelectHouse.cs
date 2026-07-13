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
    public partial class SelectHouse : Form
    {
        public string HouseID { get; set; }
        public string RentPrice { get; set; }
        public string Deposit { get; set; }
        public SelectHouse()
        {
            InitializeComponent();
        }


        private void SelectHouse_Load(object sender, EventArgs e)
        {

            //set the query condition and default is to query all house info.
            this.cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCondition.Items.Clear();
            this.cmbCondition.Items.Add("All");
            this.cmbCondition.Items.Add("Address");
            this.cmbCondition.SelectedIndex = 0;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sqlStr = string.Format("select * from HouseInfo");//Default is to query all house info.
            if (this.cmbCondition.SelectedIndex == 0) //Retrieve all house info.
            {
                sqlStr = string.Format("select * from HouseInfo");
            }
            if (this.cmbCondition.SelectedIndex == 1) //Perform fuzzy query based on the Address field
            {
                sqlStr = string.Format("select * from HouseInfo where Address like '%{0}%'", this.tbValue.Text);
            }
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            this.dgvHouseList.DataSource = ds1.Tables[0];
            this.SetDgvWidth();
        }
        private void SetDgvWidth() //Set the width of each column in the dgvHouseList
        {
            this.dgvHouseList.Columns[0].Width = 60;  //Set the width of the first column
            this.dgvHouseList.Columns[1].Width = 60;
            this.dgvHouseList.Columns[2].Width = 150;
            this.dgvHouseList.Columns[3].Width = 30;
            this.dgvHouseList.Columns[4].Width = 30;
            this.dgvHouseList.Columns[5].Width = 20;
            this.dgvHouseList.Columns[5].Width = 200;
        }

        private void dgvHouseList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Obtain the index of the selected row
            int n = this.dgvHouseList.CurrentRow.Index;
            this.HouseID = this.dgvHouseList[0, n].Value.ToString();   //House ID
            this.RentPrice = this.dgvHouseList[4, n].Value.ToString(); //House RentPrice
            this.Deposit = this.dgvHouseList[5, n].Value.ToString();   //House Deposit
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
