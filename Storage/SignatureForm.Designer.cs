namespace Storage
{
    partial class SignatureForm
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
            this.applayBTNSignaForm = new System.Windows.Forms.Button();
            this.cancelBTNSignaForm = new System.Windows.Forms.Button();
            this.signatureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signatureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // applayBTNSignaForm
            // 
            this.applayBTNSignaForm.Location = new System.Drawing.Point(315, 387);
            this.applayBTNSignaForm.Name = "applayBTNSignaForm";
            this.applayBTNSignaForm.Size = new System.Drawing.Size(75, 23);
            this.applayBTNSignaForm.TabIndex = 0;
            this.applayBTNSignaForm.Text = "Aplay";
            this.applayBTNSignaForm.UseVisualStyleBackColor = true;
            this.applayBTNSignaForm.Click += new System.EventHandler(this.applayBTNSignaForm_Click);
            // 
            // cancelBTNSignaForm
            // 
            this.cancelBTNSignaForm.Location = new System.Drawing.Point(788, 387);
            this.cancelBTNSignaForm.Name = "cancelBTNSignaForm";
            this.cancelBTNSignaForm.Size = new System.Drawing.Size(75, 23);
            this.cancelBTNSignaForm.TabIndex = 1;
            this.cancelBTNSignaForm.Text = "Cancel";
            this.cancelBTNSignaForm.UseVisualStyleBackColor = true;
            this.cancelBTNSignaForm.Click += new System.EventHandler(this.cancelBTNSignaForm_Click);
            // 
            // signatureBox
            // 
            this.signatureBox.Location = new System.Drawing.Point(0, 0);
            this.signatureBox.Name = "signatureBox";
            this.signatureBox.Size = new System.Drawing.Size(1238, 368);
            this.signatureBox.TabIndex = 2;
            this.signatureBox.TabStop = false;
            this.signatureBox.Click += new System.EventHandler(this.signatureBox_Click);
            this.signatureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.signatureBox_Paint);
            this.signatureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.signatureBox_MouseDown);
            this.signatureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.signatureBox_MouseMove);
            this.signatureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.signatureBox_MouseUp);
            // 
            // SignatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 422);
            this.Controls.Add(this.signatureBox);
            this.Controls.Add(this.cancelBTNSignaForm);
            this.Controls.Add(this.applayBTNSignaForm);
            this.Name = "SignatureForm";
            this.Text = "SignatureForm";
            this.Load += new System.EventHandler(this.SignatureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.signatureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button applayBTNSignaForm;
        private Button cancelBTNSignaForm;
        private PictureBox signatureBox;
    }
}