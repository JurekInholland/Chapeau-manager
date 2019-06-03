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
            this.pnlHistoryHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblHistoryHeadline = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.flpCustomerHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pnlDetailsHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDetailsHeadline = new System.Windows.Forms.Label();
            this.lblDetailsTable = new System.Windows.Forms.Label();
            this.lblDetailsDate = new System.Windows.Forms.Label();
            this.lblDetailsTime = new System.Windows.Forms.Label();
            this.flpDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHistoryHeader.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlDetailsHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHistoryHeader
            // 
            this.pnlHistoryHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHistoryHeader.Controls.Add(this.btnLogout);
            this.pnlHistoryHeader.Controls.Add(this.lblHistoryHeadline);
            this.pnlHistoryHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHistoryHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistoryHeader.Name = "pnlHistoryHeader";
            this.pnlHistoryHeader.Size = new System.Drawing.Size(362, 116);
            this.pnlHistoryHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.ImageIndex = 1;
            this.btnLogout.ImageList = this.imageList1;
            this.btnLogout.Location = new System.Drawing.Point(256, 48);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 36);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "back_btn.jpg");
            this.imageList1.Images.SetKeyName(1, "back.png");
            // 
            // lblHistoryHeadline
            // 
            this.lblHistoryHeadline.AutoSize = true;
            this.lblHistoryHeadline.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryHeadline.Location = new System.Drawing.Point(18, 43);
            this.lblHistoryHeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistoryHeadline.Name = "lblHistoryHeadline";
            this.lblHistoryHeadline.Size = new System.Drawing.Size(239, 37);
            this.lblHistoryHeadline.TabIndex = 0;
            this.lblHistoryHeadline.Text = "Customer history";
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.Color.White;
            this.pnlHistory.CausesValidation = false;
            this.pnlHistory.Controls.Add(this.flpCustomerHistory);
            this.pnlHistory.Controls.Add(this.pnlHistoryHeader);
            this.pnlHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(363, 775);
            this.pnlHistory.TabIndex = 2;
            // 
            // flpCustomerHistory
            // 
            this.flpCustomerHistory.AutoScroll = true;
            this.flpCustomerHistory.BackColor = System.Drawing.Color.Transparent;
            this.flpCustomerHistory.Location = new System.Drawing.Point(0, 116);
            this.flpCustomerHistory.Margin = new System.Windows.Forms.Padding(0);
            this.flpCustomerHistory.Name = "flpCustomerHistory";
            this.flpCustomerHistory.Size = new System.Drawing.Size(362, 611);
            this.flpCustomerHistory.TabIndex = 4;
            // 
            // pnlDetails
            // 
            this.pnlDetails.CausesValidation = false;
            this.pnlDetails.Controls.Add(this.pnlDetailsHeader);
            this.pnlDetails.Controls.Add(this.flpDetails);
            this.pnlDetails.Location = new System.Drawing.Point(364, 1);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(370, 775);
            this.pnlDetails.TabIndex = 4;
            // 
            // pnlDetailsHeader
            // 
            this.pnlDetailsHeader.Controls.Add(this.btnBack);
            this.pnlDetailsHeader.Controls.Add(this.lblDetailsHeadline);
            this.pnlDetailsHeader.Controls.Add(this.lblDetailsTable);
            this.pnlDetailsHeader.Controls.Add(this.lblDetailsDate);
            this.pnlDetailsHeader.Controls.Add(this.lblDetailsTime);
            this.pnlDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailsHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetailsHeader.Name = "pnlDetailsHeader";
            this.pnlDetailsHeader.Size = new System.Drawing.Size(362, 116);
            this.pnlDetailsHeader.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.imageList1;
            this.btnBack.Location = new System.Drawing.Point(8, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(74, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDetailsHeadline
            // 
            this.lblDetailsHeadline.AutoSize = true;
            this.lblDetailsHeadline.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsHeadline.Location = new System.Drawing.Point(18, 42);
            this.lblDetailsHeadline.Name = "lblDetailsHeadline";
            this.lblDetailsHeadline.Size = new System.Drawing.Size(127, 37);
            this.lblDetailsHeadline.TabIndex = 5;
            this.lblDetailsHeadline.Text = "headline";
            // 
            // lblDetailsTable
            // 
            this.lblDetailsTable.AutoSize = true;
            this.lblDetailsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTable.Location = new System.Drawing.Point(290, 84);
            this.lblDetailsTable.Name = "lblDetailsTable";
            this.lblDetailsTable.Size = new System.Drawing.Size(49, 18);
            this.lblDetailsTable.TabIndex = 3;
            this.lblDetailsTable.Text = "Table";
            // 
            // lblDetailsDate
            // 
            this.lblDetailsDate.AutoSize = true;
            this.lblDetailsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsDate.Location = new System.Drawing.Point(169, 84);
            this.lblDetailsDate.Name = "lblDetailsDate";
            this.lblDetailsDate.Size = new System.Drawing.Size(43, 18);
            this.lblDetailsDate.TabIndex = 2;
            this.lblDetailsDate.Text = "Date";
            // 
            // lblDetailsTime
            // 
            this.lblDetailsTime.AutoSize = true;
            this.lblDetailsTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTime.Location = new System.Drawing.Point(22, 84);
            this.lblDetailsTime.Name = "lblDetailsTime";
            this.lblDetailsTime.Size = new System.Drawing.Size(45, 18);
            this.lblDetailsTime.TabIndex = 0;
            this.lblDetailsTime.Text = "Time";
            // 
            // flpDetails
            // 
            this.flpDetails.Location = new System.Drawing.Point(0, 116);
            this.flpDetails.Margin = new System.Windows.Forms.Padding(0);
            this.flpDetails.Name = "flpDetails";
            this.flpDetails.Size = new System.Drawing.Size(362, 611);
            this.flpDetails.TabIndex = 4;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 775);
            this.panel1.TabIndex = 2;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Login.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(734, 739);
            this.Controls.Add(this.panel1);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.pnlHistoryHeader.ResumeLayout(false);
            this.pnlHistoryHeader.PerformLayout();
            this.pnlHistory.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetailsHeader.ResumeLayout(false);
            this.pnlDetailsHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHistoryHeader;
        private System.Windows.Forms.Label lblHistoryHeadline;
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
        private System.Windows.Forms.Panel pnlDetailsHeader;
        private System.Windows.Forms.Button btnLogout;
    }
}