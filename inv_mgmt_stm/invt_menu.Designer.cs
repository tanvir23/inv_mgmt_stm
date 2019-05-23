namespace inv_mgmt_stm
{
    partial class formMenu
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.lblMenuHeading = new System.Windows.Forms.Label();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnStockReturn = new System.Windows.Forms.Button();
            this.btnStockAccept = new System.Windows.Forms.Button();
            this.btnStockReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(241, 398);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.Location = new System.Drawing.Point(130, 79);
            this.btnStockIn.Margin = new System.Windows.Forms.Padding(10);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(120, 40);
            this.btnStockIn.TabIndex = 1;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = true;
            this.btnStockIn.Click += new System.EventHandler(this.BtnStockIn_Click);
            // 
            // lblMenuHeading
            // 
            this.lblMenuHeading.AutoSize = true;
            this.lblMenuHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuHeading.Location = new System.Drawing.Point(21, 20);
            this.lblMenuHeading.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblMenuHeading.Name = "lblMenuHeading";
            this.lblMenuHeading.Size = new System.Drawing.Size(340, 29);
            this.lblMenuHeading.TabIndex = 2;
            this.lblMenuHeading.Text = "Inventory Management System";
            // 
            // btnStockOut
            // 
            this.btnStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOut.Location = new System.Drawing.Point(130, 139);
            this.btnStockOut.Margin = new System.Windows.Forms.Padding(10);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(120, 40);
            this.btnStockOut.TabIndex = 4;
            this.btnStockOut.Text = "Stock Out";
            this.btnStockOut.UseVisualStyleBackColor = true;
            this.btnStockOut.Click += new System.EventHandler(this.BtnStockOut_Click);
            // 
            // btnStockReturn
            // 
            this.btnStockReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockReturn.Location = new System.Drawing.Point(130, 199);
            this.btnStockReturn.Margin = new System.Windows.Forms.Padding(10);
            this.btnStockReturn.Name = "btnStockReturn";
            this.btnStockReturn.Size = new System.Drawing.Size(120, 40);
            this.btnStockReturn.TabIndex = 5;
            this.btnStockReturn.Text = "Return";
            this.btnStockReturn.UseVisualStyleBackColor = true;
            this.btnStockReturn.Click += new System.EventHandler(this.BtnStockReturn_Click);
            // 
            // btnStockAccept
            // 
            this.btnStockAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockAccept.Location = new System.Drawing.Point(130, 259);
            this.btnStockAccept.Margin = new System.Windows.Forms.Padding(10);
            this.btnStockAccept.Name = "btnStockAccept";
            this.btnStockAccept.Size = new System.Drawing.Size(120, 40);
            this.btnStockAccept.TabIndex = 6;
            this.btnStockAccept.Text = "Accept";
            this.btnStockAccept.UseVisualStyleBackColor = true;
            this.btnStockAccept.Click += new System.EventHandler(this.BtnStockAccept_Click);
            // 
            // btnStockReport
            // 
            this.btnStockReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockReport.Location = new System.Drawing.Point(130, 319);
            this.btnStockReport.Margin = new System.Windows.Forms.Padding(10);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(120, 40);
            this.btnStockReport.TabIndex = 7;
            this.btnStockReport.Text = "Report";
            this.btnStockReport.UseVisualStyleBackColor = true;
            this.btnStockReport.Click += new System.EventHandler(this.BtnStockReport_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnStockReport);
            this.Controls.Add(this.btnStockAccept);
            this.Controls.Add(this.btnStockReturn);
            this.Controls.Add(this.btnStockOut);
            this.Controls.Add(this.lblMenuHeading);
            this.Controls.Add(this.btnStockIn);
            this.Controls.Add(this.btnLogout);
            this.MaximizeBox = false;
            this.Name = "formMenu";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose From Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Label lblMenuHeading;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.Button btnStockReturn;
        private System.Windows.Forms.Button btnStockAccept;
        private System.Windows.Forms.Button btnStockReport;
    }
}