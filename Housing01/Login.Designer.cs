namespace Housing01
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HouseLogo = new System.Windows.Forms.PictureBox();
            this.LoginTxt = new System.Windows.Forms.Label();
            this.Slogan = new System.Windows.Forms.Label();
            this.BigHOME = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HouseLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.tbPwd);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(450, 217);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 266);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(206, 199);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(94, 199);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 33);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(69, 136);
            this.tbPwd.Margin = new System.Windows.Forms.Padding(2);
            this.tbPwd.Multiline = true;
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(245, 34);
            this.tbPwd.TabIndex = 1;
            this.tbPwd.Text = "123456";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(69, 75);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(245, 34);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "Tomy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName:";
            // 
            // HouseLogo
            // 
            this.HouseLogo.BackColor = System.Drawing.Color.Transparent;
            this.HouseLogo.Image = ((System.Drawing.Image)(resources.GetObject("HouseLogo.Image")));
            this.HouseLogo.Location = new System.Drawing.Point(554, 28);
            this.HouseLogo.Margin = new System.Windows.Forms.Padding(2);
            this.HouseLogo.Name = "HouseLogo";
            this.HouseLogo.Size = new System.Drawing.Size(132, 95);
            this.HouseLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HouseLogo.TabIndex = 4;
            this.HouseLogo.TabStop = false;
            // 
            // LoginTxt
            // 
            this.LoginTxt.BackColor = System.Drawing.Color.Transparent;
            this.LoginTxt.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.LoginTxt.Location = new System.Drawing.Point(584, 201);
            this.LoginTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(83, 32);
            this.LoginTxt.TabIndex = 7;
            this.LoginTxt.Text = "Login";
            // 
            // Slogan
            // 
            this.Slogan.BackColor = System.Drawing.Color.Transparent;
            this.Slogan.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slogan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Slogan.Location = new System.Drawing.Point(535, 175);
            this.Slogan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(264, 26);
            this.Slogan.TabIndex = 6;
            this.Slogan.Text = "Your Home-Your Choice";
            // 
            // BigHOME
            // 
            this.BigHOME.BackColor = System.Drawing.Color.Transparent;
            this.BigHOME.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigHOME.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BigHOME.Location = new System.Drawing.Point(504, 101);
            this.BigHOME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BigHOME.Name = "BigHOME";
            this.BigHOME.Size = new System.Drawing.Size(324, 82);
            this.BigHOME.TabIndex = 5;
            this.BigHOME.Text = "HOME";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Housing01.Properties.Resources.Iloginpage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 602);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.HouseLogo);
            this.Controls.Add(this.Slogan);
            this.Controls.Add(this.BigHOME);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HouseLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox HouseLogo;
        private System.Windows.Forms.Label LoginTxt;
        private System.Windows.Forms.Label Slogan;
        private System.Windows.Forms.Label BigHOME;
    }
}