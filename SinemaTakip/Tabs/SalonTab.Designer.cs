namespace SinemaSeansTakip.Tabs
{
    partial class SalonTab
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtKapasite = new TextBox();
            Salon = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            btnOnay = new Button();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(778, 579);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.0546951F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.9453F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(775, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(565, 70);
            label1.TabIndex = 0;
            label1.Text = "Yeni salon kaydı oluşturmak için aşağıdaki alanları doldurunuz:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(txtKapasite, 1, 1);
            tableLayoutPanel2.Controls.Add(Salon, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(txtAd, 1, 0);
            tableLayoutPanel2.Controls.Add(btnOnay, 1, 2);
            tableLayoutPanel2.Location = new Point(3, 134);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0501213F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.050127F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.050127F));
            tableLayoutPanel2.Size = new Size(775, 445);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // txtKapasite
            // 
            txtKapasite.Anchor = AnchorStyles.Left;
            txtKapasite.Font = new Font("Segoe UI", 14F);
            txtKapasite.Location = new Point(390, 202);
            txtKapasite.Name = "txtKapasite";
            txtKapasite.Size = new Size(226, 39);
            txtKapasite.TabIndex = 9;
            // 
            // Salon
            // 
            Salon.Anchor = AnchorStyles.Left;
            Salon.AutoSize = true;
            Salon.Font = new Font("Segoe UI", 14F);
            Salon.Location = new Point(3, 206);
            Salon.Name = "Salon";
            Salon.Size = new Size(103, 32);
            Salon.TabIndex = 1;
            Salon.Text = "Kapasite";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 0;
            label3.Text = "Salon Adı:";
            // 
            // txtAd
            // 
            txtAd.Anchor = AnchorStyles.Left;
            txtAd.Font = new Font("Segoe UI", 14F);
            txtAd.Location = new Point(390, 54);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(226, 39);
            txtAd.TabIndex = 8;
            // 
            // btnOnay
            // 
            btnOnay.Anchor = AnchorStyles.Right;
            btnOnay.Font = new Font("Segoe UI", 14F);
            btnOnay.Location = new Point(639, 352);
            btnOnay.Name = "btnOnay";
            btnOnay.Size = new Size(133, 37);
            btnOnay.TabIndex = 5;
            btnOnay.Text = "Onayla";
            btnOnay.UseVisualStyleBackColor = true;
            btnOnay.Click += btnOnay_Click;
            // 
            // SalonTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(802, 603);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SalonTab";
            Text = "Salon";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtKapasite;
        private Label Salon;
        private Label label3;
        private Button btnOnay;
        private TextBox txtAd;
    }
}