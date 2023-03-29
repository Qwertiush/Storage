namespace Storage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.camerasComBox = new System.Windows.Forms.ComboBox();
            this.barcodePicBox = new System.Windows.Forms.PictureBox();
            this.barcodeTxT = new System.Windows.Forms.TextBox();
            this.startCapturBTN = new System.Windows.Forms.Button();
            this.goToSignatureBTN = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.dataBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barcode";
            // 
            // camerasComBox
            // 
            this.camerasComBox.FormattingEnabled = true;
            this.camerasComBox.Location = new System.Drawing.Point(67, 42);
            this.camerasComBox.Name = "camerasComBox";
            this.camerasComBox.Size = new System.Drawing.Size(593, 23);
            this.camerasComBox.TabIndex = 2;
            // 
            // barcodePicBox
            // 
            this.barcodePicBox.Location = new System.Drawing.Point(12, 88);
            this.barcodePicBox.Name = "barcodePicBox";
            this.barcodePicBox.Size = new System.Drawing.Size(648, 415);
            this.barcodePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.barcodePicBox.TabIndex = 3;
            this.barcodePicBox.TabStop = false;
            // 
            // barcodeTxT
            // 
            this.barcodeTxT.Location = new System.Drawing.Point(62, 509);
            this.barcodeTxT.Name = "barcodeTxT";
            this.barcodeTxT.Size = new System.Drawing.Size(598, 23);
            this.barcodeTxT.TabIndex = 4;
            // 
            // startCapturBTN
            // 
            this.startCapturBTN.Location = new System.Drawing.Point(701, 266);
            this.startCapturBTN.Name = "startCapturBTN";
            this.startCapturBTN.Size = new System.Drawing.Size(75, 23);
            this.startCapturBTN.TabIndex = 5;
            this.startCapturBTN.Text = "Scan";
            this.startCapturBTN.UseVisualStyleBackColor = true;
            this.startCapturBTN.Click += new System.EventHandler(this.startCapturBTN_Click);
            // 
            // goToSignatureBTN
            // 
            this.goToSignatureBTN.Location = new System.Drawing.Point(701, 509);
            this.goToSignatureBTN.Name = "goToSignatureBTN";
            this.goToSignatureBTN.Size = new System.Drawing.Size(75, 23);
            this.goToSignatureBTN.TabIndex = 6;
            this.goToSignatureBTN.Text = "Next";
            this.goToSignatureBTN.UseVisualStyleBackColor = true;
            this.goToSignatureBTN.Click += new System.EventHandler(this.goToSignatureBTN_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(701, 88);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 7;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // dataBTN
            // 
            this.dataBTN.Location = new System.Drawing.Point(701, 42);
            this.dataBTN.Name = "dataBTN";
            this.dataBTN.Size = new System.Drawing.Size(75, 23);
            this.dataBTN.TabIndex = 8;
            this.dataBTN.Text = "Data";
            this.dataBTN.UseVisualStyleBackColor = true;
            this.dataBTN.Click += new System.EventHandler(this.dataBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 544);
            this.Controls.Add(this.dataBTN);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.goToSignatureBTN);
            this.Controls.Add(this.startCapturBTN);
            this.Controls.Add(this.barcodeTxT);
            this.Controls.Add(this.barcodePicBox);
            this.Controls.Add(this.camerasComBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barcodePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox camerasComBox;
        private PictureBox barcodePicBox;
        private TextBox barcodeTxT;
        private Button startCapturBTN;
        private Button goToSignatureBTN;
        private Button addItemButton;
        private Button dataBTN;
    }
}