namespace Storage
{
    partial class DataForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backBTNDataF = new System.Windows.Forms.Button();
            this.editBTNDataF = new System.Windows.Forms.Button();
            this.searchBTNDataF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxTBoxDataF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusComBoxdataF = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(644, 528);
            this.dataGridView1.TabIndex = 0;
            // 
            // backBTNDataF
            // 
            this.backBTNDataF.Location = new System.Drawing.Point(676, 590);
            this.backBTNDataF.Name = "backBTNDataF";
            this.backBTNDataF.Size = new System.Drawing.Size(75, 23);
            this.backBTNDataF.TabIndex = 1;
            this.backBTNDataF.Text = "Back";
            this.backBTNDataF.UseVisualStyleBackColor = true;
            this.backBTNDataF.Click += new System.EventHandler(this.backBTNDataF_Click);
            // 
            // editBTNDataF
            // 
            this.editBTNDataF.Location = new System.Drawing.Point(676, 12);
            this.editBTNDataF.Name = "editBTNDataF";
            this.editBTNDataF.Size = new System.Drawing.Size(75, 23);
            this.editBTNDataF.TabIndex = 2;
            this.editBTNDataF.Text = "Edit";
            this.editBTNDataF.UseVisualStyleBackColor = true;
            this.editBTNDataF.Click += new System.EventHandler(this.editBTNDataF_Click);
            // 
            // searchBTNDataF
            // 
            this.searchBTNDataF.Location = new System.Drawing.Point(676, 52);
            this.searchBTNDataF.Name = "searchBTNDataF";
            this.searchBTNDataF.Size = new System.Drawing.Size(75, 23);
            this.searchBTNDataF.TabIndex = 3;
            this.searchBTNDataF.Text = "Search";
            this.searchBTNDataF.UseVisualStyleBackColor = true;
            this.searchBTNDataF.Click += new System.EventHandler(this.searchBTNDataF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name or Barcode";
            // 
            // nameTxTBoxDataF
            // 
            this.nameTxTBoxDataF.AcceptsReturn = true;
            this.nameTxTBoxDataF.Location = new System.Drawing.Point(12, 53);
            this.nameTxTBoxDataF.Name = "nameTxTBoxDataF";
            this.nameTxTBoxDataF.Size = new System.Drawing.Size(466, 23);
            this.nameTxTBoxDataF.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // statusComBoxdataF
            // 
            this.statusComBoxdataF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComBoxdataF.FormattingEnabled = true;
            this.statusComBoxdataF.Location = new System.Drawing.Point(484, 53);
            this.statusComBoxdataF.Name = "statusComBoxdataF";
            this.statusComBoxdataF.Size = new System.Drawing.Size(172, 23);
            this.statusComBoxdataF.TabIndex = 11;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 625);
            this.Controls.Add(this.statusComBoxdataF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTxTBoxDataF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBTNDataF);
            this.Controls.Add(this.editBTNDataF);
            this.Controls.Add(this.backBTNDataF);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button backBTNDataF;
        private Button editBTNDataF;
        private Button searchBTNDataF;
        private Label label2;
        private TextBox nameTxTBoxDataF;
        private Label label4;
        private ComboBox statusComBoxdataF;
    }
}