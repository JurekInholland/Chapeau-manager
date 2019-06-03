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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new Login.BufferedPanel(this.components);
            this.pnlDetails = new Login.BufferedPanel(this.components);
            this.pnlDetailsHeader = new Login.BufferedPanel(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDetailsHeadline = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetailsTime = new System.Windows.Forms.Label();
            this.lblDetailsDate = new System.Windows.Forms.Label();
            this.lblDetailsTable = new System.Windows.Forms.Label();
            this.flpDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHistory = new Login.BufferedPanel(this.components);
            this.flpCustomerHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHistoryHeader = new Login.BufferedPanel(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHistoryHeadline = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlDetailsHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.pnlHistoryHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "back_btn.jpg");
            this.imageList1.Images.SetKeyName(1, "back.png");
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 15;
            this.animationTimer.Tick += new System.EventHandler(this.AnimationTick);
            // 
            // panel1
            // 
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.pnlDetails);
            this.panel1.Controls.Add(this.pnlHistory);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 775);
            this.panel1.TabIndex = 2;
            // 
            // pnlDetails
            // 
            this.pnlDetails.CausesValidation = false;
            this.pnlDetails.Controls.Add(this.pnlDetailsHeader);
            this.pnlDetails.Controls.Add(this.flpDetails);
            this.pnlDetails.Location = new System.Drawing.Point(360, 1);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(368, 775);
            this.pnlDetails.TabIndex = 4;
            // 
            // pnlDetailsHeader
            // 
            this.pnlDetailsHeader.Controls.Add(this.btnBack);
            this.pnlDetailsHeader.Controls.Add(this.lblDetailsHeadline);
            this.pnlDetailsHeader.Controls.Add(this.tableLayoutPanel1);
            this.pnlDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailsHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetailsHeader.Name = "pnlDetailsHeader";
            this.pnlDetailsHeader.Size = new System.Drawing.Size(368, 116);
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
            this.btnBack.Location = new System.Drawing.Point(5, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BackClick);
            // 
            // lblDetailsHeadline
            // 
            this.lblDetailsHeadline.AutoSize = true;
            this.lblDetailsHeadline.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsHeadline.Location = new System.Drawing.Point(13, 42);
            this.lblDetailsHeadline.Name = "lblDetailsHeadline";
            this.lblDetailsHeadline.Size = new System.Drawing.Size(177, 37);
            this.lblDetailsHeadline.TabIndex = 5;
            this.lblDetailsHeadline.Text = "Details page";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.lblDetailsTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDetailsDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDetailsTable, 3, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 28);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblDetailsTime
            // 
            this.lblDetailsTime.AutoSize = true;
            this.lblDetailsTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTime.Location = new System.Drawing.Point(13, 0);
            this.lblDetailsTime.Name = "lblDetailsTime";
            this.lblDetailsTime.Size = new System.Drawing.Size(45, 18);
            this.lblDetailsTime.TabIndex = 0;
            this.lblDetailsTime.Text = "Time";
            // 
            // lblDetailsDate
            // 
            this.lblDetailsDate.AutoSize = true;
            this.lblDetailsDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDetailsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsDate.Location = new System.Drawing.Point(132, 0);
            this.lblDetailsDate.Name = "lblDetailsDate";
            this.lblDetailsDate.Size = new System.Drawing.Size(43, 28);
            this.lblDetailsDate.TabIndex = 2;
            this.lblDetailsDate.Text = "Date";
            // 
            // lblDetailsTable
            // 
            this.lblDetailsTable.AutoSize = true;
            this.lblDetailsTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDetailsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTable.Location = new System.Drawing.Point(298, 0);
            this.lblDetailsTable.Name = "lblDetailsTable";
            this.lblDetailsTable.Size = new System.Drawing.Size(49, 28);
            this.lblDetailsTable.TabIndex = 3;
            this.lblDetailsTable.Text = "Table";
            // 
            // flpDetails
            // 
            this.flpDetails.Location = new System.Drawing.Point(0, 116);
            this.flpDetails.Margin = new System.Windows.Forms.Padding(0);
            this.flpDetails.Name = "flpDetails";
            this.flpDetails.Size = new System.Drawing.Size(368, 647);
            this.flpDetails.TabIndex = 4;
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
            this.flpCustomerHistory.Location = new System.Drawing.Point(0, 117);
            this.flpCustomerHistory.Margin = new System.Windows.Forms.Padding(0);
            this.flpCustomerHistory.Name = "flpCustomerHistory";
            this.flpCustomerHistory.Size = new System.Drawing.Size(380, 647);
            this.flpCustomerHistory.TabIndex = 4;
            // 
            // pnlHistoryHeader
            // 
            this.pnlHistoryHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHistoryHeader.Controls.Add(this.btnLogout);
            this.pnlHistoryHeader.Controls.Add(this.lblHistoryHeadline);
            this.pnlHistoryHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHistoryHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistoryHeader.Name = "pnlHistoryHeader";
            this.pnlHistoryHeader.Size = new System.Drawing.Size(362, 117);
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
            this.btnLogout.Location = new System.Drawing.Point(249, 38);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 55);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.LogoutClick);
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
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Login.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(359, 773);
            this.Controls.Add(this.panel1);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.panel1.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetailsHeader.ResumeLayout(false);
            this.pnlDetailsHeader.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlHistory.ResumeLayout(false);
            this.pnlHistoryHeader.ResumeLayout(false);
            this.pnlHistoryHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BufferedPanel pnlHistoryHeader;
        private System.Windows.Forms.Label lblHistoryHeadline;
        private System.Windows.Forms.FlowLayoutPanel flpCustomerHistory;
        private System.Windows.Forms.FlowLayoutPanel flpDetails;
        private System.Windows.Forms.Label lblDetailsDate;
        private System.Windows.Forms.Label lblDetailsTime;
        private System.Windows.Forms.Label lblDetailsHeadline;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button btnLogout;
        private BufferedPanel pnlHistory;
        private BufferedPanel pnlDetails;
        private BufferedPanel panel1;
        private BufferedPanel pnlDetailsHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDetailsTable;
    }
}