namespace MiniPosSystem
{
    partial class frmManageServers
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
            this.btnUpdateServ = new System.Windows.Forms.Button();
            this.btnDeleteServ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateServ
            // 
            this.btnUpdateServ.Location = new System.Drawing.Point(77, 242);
            this.btnUpdateServ.Name = "btnUpdateServ";
            this.btnUpdateServ.Size = new System.Drawing.Size(153, 74);
            this.btnUpdateServ.TabIndex = 0;
            this.btnUpdateServ.Text = "Update Server";
            this.btnUpdateServ.UseVisualStyleBackColor = true;
            this.btnUpdateServ.Click += new System.EventHandler(this.BtnUpdateServ_Click);
            // 
            // btnDeleteServ
            // 
            this.btnDeleteServ.Location = new System.Drawing.Point(357, 242);
            this.btnDeleteServ.Name = "btnDeleteServ";
            this.btnDeleteServ.Size = new System.Drawing.Size(153, 74);
            this.btnDeleteServ.TabIndex = 1;
            this.btnDeleteServ.Text = "Delete Server";
            this.btnDeleteServ.UseVisualStyleBackColor = true;
            this.btnDeleteServ.Click += new System.EventHandler(this.BtnDeleteServ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name: ";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(193, 103);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(208, 26);
            this.txtLName.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(193, 45);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(208, 26);
            this.txtFName.TabIndex = 5;
            // 
            // frmManageServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 363);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteServ);
            this.Controls.Add(this.btnUpdateServ);
            this.Name = "frmManageServers";
            this.Text = "Update Server";
            this.Load += new System.EventHandler(this.FrmManageServers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateServ;
        private System.Windows.Forms.Button btnDeleteServ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
    }
}