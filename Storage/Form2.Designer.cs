namespace Storage
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxTBoxF2 = new System.Windows.Forms.TextBox();
            this.codeTxTBoxF2 = new System.Windows.Forms.TextBox();
            this.addBTNF2 = new System.Windows.Forms.Button();
            this.cancelBTNF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // nameTxTBoxF2
            // 
            this.nameTxTBoxF2.Location = new System.Drawing.Point(103, 33);
            this.nameTxTBoxF2.Name = "nameTxTBoxF2";
            this.nameTxTBoxF2.Size = new System.Drawing.Size(391, 23);
            this.nameTxTBoxF2.TabIndex = 4;
            // 
            // codeTxTBoxF2
            // 
            this.codeTxTBoxF2.Location = new System.Drawing.Point(103, 67);
            this.codeTxTBoxF2.Name = "codeTxTBoxF2";
            this.codeTxTBoxF2.Size = new System.Drawing.Size(391, 23);
            this.codeTxTBoxF2.TabIndex = 5;
            // 
            // addBTNF2
            // 
            this.addBTNF2.Location = new System.Drawing.Point(158, 120);
            this.addBTNF2.Name = "addBTNF2";
            this.addBTNF2.Size = new System.Drawing.Size(75, 23);
            this.addBTNF2.TabIndex = 7;
            this.addBTNF2.Text = "Add";
            this.addBTNF2.UseVisualStyleBackColor = true;
            this.addBTNF2.Click += new System.EventHandler(this.addBTNF2_Click);
            // 
            // cancelBTNF2
            // 
            this.cancelBTNF2.Location = new System.Drawing.Point(301, 120);
            this.cancelBTNF2.Name = "cancelBTNF2";
            this.cancelBTNF2.Size = new System.Drawing.Size(75, 23);
            this.cancelBTNF2.TabIndex = 8;
            this.cancelBTNF2.Text = "Cancel";
            this.cancelBTNF2.UseVisualStyleBackColor = true;
            this.cancelBTNF2.Click += new System.EventHandler(this.cancelBTNF2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 201);
            this.Controls.Add(this.cancelBTNF2);
            this.Controls.Add(this.addBTNF2);
            this.Controls.Add(this.codeTxTBoxF2);
            this.Controls.Add(this.nameTxTBoxF2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTxTBoxF2;
        private TextBox codeTxTBoxF2;
        private Button addBTNF2;
        private Button cancelBTNF2;
    }
}