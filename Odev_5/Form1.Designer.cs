namespace Odev_5
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
            btnOdemeYap = new Button();
            lblOdemeTipi = new Label();
            lblTutar = new Label();
            lblSonuc = new Label();
            cmbOdemeTipi = new ComboBox();
            txtTutar = new TextBox();
            SuspendLayout();
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Location = new Point(312, 258);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(179, 51);
            btnOdemeYap.TabIndex = 0;
            btnOdemeYap.Text = "ÖDEME YAP";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // lblOdemeTipi
            // 
            lblOdemeTipi.AutoSize = true;
            lblOdemeTipi.Location = new Point(112, 89);
            lblOdemeTipi.Name = "lblOdemeTipi";
            lblOdemeTipi.Size = new Size(98, 20);
            lblOdemeTipi.TabIndex = 1;
            lblOdemeTipi.Text = "Ödeme Tipi : ";
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            lblTutar.Location = new Point(112, 153);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(54, 20);
            lblTutar.TabIndex = 2;
            lblTutar.Text = "Tutar : ";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(112, 345);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(60, 20);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "Sonuç : ";
            // 
            // cmbOdemeTipi
            // 
            cmbOdemeTipi.FormattingEnabled = true;
            cmbOdemeTipi.Location = new Point(249, 86);
            cmbOdemeTipi.Name = "cmbOdemeTipi";
            cmbOdemeTipi.Size = new Size(350, 28);
            cmbOdemeTipi.TabIndex = 4;
            cmbOdemeTipi.SelectedIndexChanged += cmbOdemeTipi_SelectedIndexChanged;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(249, 150);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(350, 27);
            txtTutar.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTutar);
            Controls.Add(cmbOdemeTipi);
            Controls.Add(lblSonuc);
            Controls.Add(lblTutar);
            Controls.Add(lblOdemeTipi);
            Controls.Add(btnOdemeYap);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdemeYap;
        private Label lblOdemeTipi;
        private Label lblTutar;
        private Label lblSonuc;
        private ComboBox cmbOdemeTipi;
        private TextBox txtTutar;
    }
}
