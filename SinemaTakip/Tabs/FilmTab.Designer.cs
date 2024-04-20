namespace SinemaSeansTakip.Tabs
{
    partial class FilmTab
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
            txtAciklama = new TextBox();
            txtYonetmen = new TextBox();
            Salon = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimeRelease = new DateTimePicker();
            txtAd = new TextBox();
            btnOnay = new Button();
            label4 = new Label();
            txtSure = new TextBox();
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
            flowLayoutPanel1.TabIndex = 1;
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
            label1.Location = new Point(3, 45);
            label1.Name = "label1";
            label1.Size = new Size(687, 35);
            label1.TabIndex = 0;
            label1.Text = "Yeni film kaydı oluşturmak için aşağıdaki alanları doldurunuz:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(txtAciklama, 1, 3);
            tableLayoutPanel2.Controls.Add(txtYonetmen, 1, 1);
            tableLayoutPanel2.Controls.Add(Salon, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(dateTimeRelease, 1, 2);
            tableLayoutPanel2.Controls.Add(txtAd, 1, 0);
            tableLayoutPanel2.Controls.Add(btnOnay, 1, 5);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Controls.Add(txtSure, 1, 4);
            tableLayoutPanel2.Location = new Point(3, 134);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7084332F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7084389F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7084389F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.5413551F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(775, 445);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // txtAciklama
            // 
            txtAciklama.Anchor = AnchorStyles.Left;
            txtAciklama.Font = new Font("Segoe UI", 14F);
            txtAciklama.Location = new Point(390, 239);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(226, 39);
            txtAciklama.TabIndex = 10;
            // 
            // txtYonetmen
            // 
            txtYonetmen.Anchor = AnchorStyles.Left;
            txtYonetmen.Font = new Font("Segoe UI", 14F);
            txtYonetmen.Location = new Point(390, 91);
            txtYonetmen.Name = "txtYonetmen";
            txtYonetmen.Size = new Size(226, 39);
            txtYonetmen.TabIndex = 9;
            // 
            // Salon
            // 
            Salon.Anchor = AnchorStyles.Left;
            Salon.AutoSize = true;
            Salon.Font = new Font("Segoe UI", 14F);
            Salon.Location = new Point(3, 95);
            Salon.Name = "Salon";
            Salon.Size = new Size(127, 32);
            Salon.TabIndex = 1;
            Salon.Text = "Yönetmen:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(3, 169);
            label5.Name = "label5";
            label5.Size = new Size(131, 32);
            label5.TabIndex = 2;
            label5.Text = "Çıkış Tarihi:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 21);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 0;
            label3.Text = "Film Adı:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 242);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 6;
            label2.Text = "Açıklama:";
            // 
            // dateTimeRelease
            // 
            dateTimeRelease.Anchor = AnchorStyles.Left;
            dateTimeRelease.Location = new Point(390, 171);
            dateTimeRelease.Name = "dateTimeRelease";
            dateTimeRelease.Size = new Size(250, 27);
            dateTimeRelease.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.Anchor = AnchorStyles.Left;
            txtAd.Font = new Font("Segoe UI", 14F);
            txtAd.Location = new Point(390, 17);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(226, 39);
            txtAd.TabIndex = 8;
            // 
            // btnOnay
            // 
            btnOnay.Anchor = AnchorStyles.Right;
            btnOnay.Font = new Font("Segoe UI", 14F);
            btnOnay.Location = new Point(639, 388);
            btnOnay.Name = "btnOnay";
            btnOnay.Size = new Size(133, 37);
            btnOnay.TabIndex = 5;
            btnOnay.Text = "Onayla";
            btnOnay.UseVisualStyleBackColor = true;
            btnOnay.Click += btnOnay_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(3, 316);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 11;
            label4.Text = "Film Süresi:";
            // 
            // txtSure
            // 
            txtSure.Anchor = AnchorStyles.Left;
            txtSure.Font = new Font("Segoe UI", 14F);
            txtSure.Location = new Point(390, 312);
            txtSure.Name = "txtSure";
            txtSure.Size = new Size(226, 39);
            txtSure.TabIndex = 12;
            // 
            // FilmTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(802, 603);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FilmTab";
            Text = "FilmTab";
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
        private Label Salon;
        private Label label5;
        private Button btnOnay;
        private Label label3;
        private Label label2;
        private TextBox txtAciklama;
        private TextBox txtYonetmen;
        private DateTimePicker dateTimeRelease;
        private TextBox txtAd;
        private Label label4;
        private TextBox txtSure;
    }
}