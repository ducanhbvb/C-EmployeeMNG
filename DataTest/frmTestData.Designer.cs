namespace DataTest
{
    partial class frmTestData
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
            this.splcMain = new System.Windows.Forms.SplitContainer();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.grdDataList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splcMain)).BeginInit();
            this.splcMain.Panel1.SuspendLayout();
            this.splcMain.Panel2.SuspendLayout();
            this.splcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // splcMain
            // 
            this.splcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcMain.Location = new System.Drawing.Point(0, 0);
            this.splcMain.Name = "splcMain";
            this.splcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcMain.Panel1
            // 
            this.splcMain.Panel1.Controls.Add(this.txtBox2);
            this.splcMain.Panel1.Controls.Add(this.txtBox1);
            this.splcMain.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splcMain_Panel1_Paint);
            // 
            // splcMain.Panel2
            // 
            this.splcMain.Panel2.Controls.Add(this.grdDataList);
            this.splcMain.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splcMain_Panel2_Paint);
            this.splcMain.Size = new System.Drawing.Size(661, 521);
            this.splcMain.SplitterDistance = 67;
            this.splcMain.TabIndex = 0;
            // 
            // txtBox2
            // 
            this.txtBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox2.Location = new System.Drawing.Point(0, 44);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(661, 20);
            this.txtBox2.TabIndex = 1;
            this.txtBox2.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            // 
            // txtBox1
            // 
            this.txtBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox1.Location = new System.Drawing.Point(0, 0);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(661, 20);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged_1);
            this.txtBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox1_KeyDown);
            // 
            // grdDataList
            // 
            this.grdDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDataList.Location = new System.Drawing.Point(0, 0);
            this.grdDataList.Name = "grdDataList";
            this.grdDataList.Size = new System.Drawing.Size(661, 450);
            this.grdDataList.TabIndex = 0;
            this.grdDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDataList_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date";
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Avatar";
            this.Column4.HeaderText = "Avatar";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Salary";
            this.Column5.HeaderText = "Salary";
            this.Column5.Name = "Column5";
            // 
            // frmTestData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 521);
            this.Controls.Add(this.splcMain);
            this.Name = "frmTestData";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTestData_Load);
            this.splcMain.Panel1.ResumeLayout(false);
            this.splcMain.Panel1.PerformLayout();
            this.splcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcMain)).EndInit();
            this.splcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splcMain;
        private System.Windows.Forms.DataGridView grdDataList;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtBox2;
    }
}

