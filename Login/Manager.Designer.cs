namespace Login
{
    partial class Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblHistoryHeadline = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.flpCustomerHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flpDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDetailsHeadline = new System.Windows.Forms.Label();
            this.lblDetailsTable = new System.Windows.Forms.Label();
            this.lblDetailsDate = new System.Windows.Forms.Label();
            this.lblDetailsTime = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblLogout);
            this.pnlHeader.Controls.Add(this.lblHistoryHeadline);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(740, 217);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Crimson;
            this.lblLogout.Location = new System.Drawing.Point(572, 122);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(145, 36);
            this.lblLogout.TabIndex = 1;
            this.lblLogout.Text = "<- Log out";
            this.lblLogout.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblHistoryHeadline
            // 
            this.lblHistoryHeadline.AutoSize = true;
            this.lblHistoryHeadline.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryHeadline.Location = new System.Drawing.Point(13, 94);
            this.lblHistoryHeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistoryHeadline.Name = "lblHistoryHeadline";
            this.lblHistoryHeadline.Size = new System.Drawing.Size(467, 72);
            this.lblHistoryHeadline.TabIndex = 0;
            this.lblHistoryHeadline.Text = "Customer history";
            // 
            // pnlHistory
            // 
            this.pnlHistory.CausesValidation = false;
            this.pnlHistory.Controls.Add(this.pnlHeader);
            this.pnlHistory.Controls.Add(this.flpCustomerHistory);
            this.pnlHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(6);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(726, 1491);
            this.pnlHistory.TabIndex = 2;
            // 
            // flpCustomerHistory
            // 
            this.flpCustomerHistory.AutoScroll = true;
            this.flpCustomerHistory.Location = new System.Drawing.Point(2, 215);
            this.flpCustomerHistory.Margin = new System.Windows.Forms.Padding(6);
            this.flpCustomerHistory.Name = "flpCustomerHistory";
            this.flpCustomerHistory.Size = new System.Drawing.Size(724, 682);
            this.flpCustomerHistory.TabIndex = 4;
            // 
            // pnlDetails
            // 
            this.pnlDetails.CausesValidation = false;
            this.pnlDetails.Controls.Add(this.btnBack);
            this.pnlDetails.Controls.Add(this.flpDetails);
            this.pnlDetails.Controls.Add(this.lblDetailsHeadline);
            this.pnlDetails.Controls.Add(this.lblDetailsTable);
            this.pnlDetails.Controls.Add(this.lblDetailsDate);
            this.pnlDetails.Controls.Add(this.lblDetailsTime);
            this.pnlDetails.Location = new System.Drawing.Point(727, 1);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(739, 1490);
            this.pnlDetails.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.imageList1;
            this.btnBack.Location = new System.Drawing.Point(17, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 54);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "back_btn.jpg");
            this.imageList1.Images.SetKeyName(1, "back.png");
            // 
            // flpDetails
            // 
            this.flpDetails.Location = new System.Drawing.Point(0, 215);
            this.flpDetails.Margin = new System.Windows.Forms.Padding(6);
            this.flpDetails.Name = "flpDetails";
            this.flpDetails.Size = new System.Drawing.Size(724, 681);
            this.flpDetails.TabIndex = 4;
            // 
            // lblDetailsHeadline
            // 
            this.lblDetailsHeadline.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDetailsHeadline.Location = new System.Drawing.Point(24, 94);
            this.lblDetailsHeadline.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDetailsHeadline.Name = "lblDetailsHeadline";
            this.lblDetailsHeadline.Size = new System.Drawing.Size(470, 42);
            this.lblDetailsHeadline.TabIndex = 5;
            this.lblDetailsHeadline.Text = "headline";
            // 
            // lblDetailsTable
            // 
            this.lblDetailsTable.AutoSize = true;
            this.lblDetailsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTable.Location = new System.Drawing.Point(578, 162);
            this.lblDetailsTable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDetailsTable.Name = "lblDetailsTable";
            this.lblDetailsTable.Size = new System.Drawing.Size(94, 36);
            this.lblDetailsTable.TabIndex = 3;
            this.lblDetailsTable.Text = "Table";
            // 
            // lblDetailsDate
            // 
            this.lblDetailsDate.AutoSize = true;
            this.lblDetailsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsDate.Location = new System.Drawing.Point(312, 162);
            this.lblDetailsDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDetailsDate.Name = "lblDetailsDate";
            this.lblDetailsDate.Size = new System.Drawing.Size(80, 36);
            this.lblDetailsDate.TabIndex = 2;
            this.lblDetailsDate.Text = "Date";
            // 
            // lblDetailsTime
            // 
            this.lblDetailsTime.AutoSize = true;
            this.lblDetailsTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTime.Location = new System.Drawing.Point(24, 162);
            this.lblDetailsTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDetailsTime.Name = "lblDetailsTime";
            this.lblDetailsTime.Size = new System.Drawing.Size(83, 36);
            this.lblDetailsTime.TabIndex = 0;
            this.lblDetailsTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.pnlDetails);
            this.panel1.Controls.Add(this.pnlHistory);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 1491);
            this.panel1.TabIndex = 2;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1462, 1487);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHistory.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHistoryHeadline;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.FlowLayoutPanel flpCustomerHistory;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.FlowLayoutPanel flpDetails;
        private System.Windows.Forms.Label lblDetailsTable;
        private System.Windows.Forms.Label lblDetailsDate;
        private System.Windows.Forms.Label lblDetailsTime;
        private System.Windows.Forms.Label lblDetailsHeadline;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}