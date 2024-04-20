namespace SinemaSeansTakip.Tabs
{
    partial class SeansTab
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
            txtUcret = new TextBox();
            txtSure = new TextBox();
            textBaslangic = new TextBox();
            txtSalonId = new TextBox();
            Salon = new Label();
            label3 = new Label();
            txtFilmId = new TextBox();
            btnOnay = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            flowLayoutPanel1.TabIndex = 3;
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
            label1.Size = new Size(568, 70);
            label1.TabIndex = 0;
            label1.Text = "Yeni seans kaydı oluşturmak için aşağıdaki alanları doldurunuz:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(txtUcret, 1, 4);
            tableLayoutPanel2.Controls.Add(txtSure, 1, 3);
            tableLayoutPanel2.Controls.Add(textBaslangic, 1, 2);
            tableLayoutPanel2.Controls.Add(txtSalonId, 1, 1);
            tableLayoutPanel2.Controls.Add(Salon, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(txtFilmId, 1, 0);
            tableLayoutPanel2.Controls.Add(btnOnay, 1, 5);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Location = new Point(3, 134);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.687521F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6875267F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6875267F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6458073F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6458073F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6458073F));
            tableLayoutPanel2.Size = new Size(775, 445);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // txtUcret
            // 
            txtUcret.Anchor = AnchorStyles.Left;
            txtUcret.Font = new Font("Segoe UI", 14F);
            txtUcret.Location = new Point(390, 313);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(226, 39);
            txtUcret.TabIndex = 15;
            // 
            // txtSure
            // 
            txtSure.Anchor = AnchorStyles.Left;
            txtSure.Font = new Font("Segoe UI", 14F);
            txtSure.Location = new Point(390, 239);
            txtSure.Name = "txtSure";
            txtSure.Size = new Size(226, 39);
            txtSure.TabIndex = 14;
            // 
            // textBaslangic
            // 
            textBaslangic.Anchor = AnchorStyles.Left;
            textBaslangic.Font = new Font("Segoe UI", 14F);
            textBaslangic.Location = new Point(390, 165);
            textBaslangic.Name = "textBaslangic";
            textBaslangic.Size = new Size(226, 39);
            textBaslangic.TabIndex = 13;
            // 
            // txtSalonId
            // 
            txtSalonId.Anchor = AnchorStyles.Left;
            txtSalonId.Font = new Font("Segoe UI", 14F);
            txtSalonId.Location = new Point(390, 91);
            txtSalonId.Name = "txtSalonId";
            txtSalonId.Size = new Size(226, 39);
            txtSalonId.TabIndex = 9;
            // 
            // Salon
            // 
            Salon.Anchor = AnchorStyles.Left;
            Salon.AutoSize = true;
            Salon.Font = new Font("Segoe UI", 14F);
            Salon.Location = new Point(3, 95);
            Salon.Name = "Salon";
            Salon.Size = new Size(93, 32);
            Salon.TabIndex = 1;
            Salon.Text = "SalonId";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 21);
            label3.Name = "label3";
            label3.Size = new Size(84, 32);
            label3.TabIndex = 0;
            label3.Text = "FilmId:";
            // 
            // txtFilmId
            // 
            txtFilmId.Anchor = AnchorStyles.Left;
            txtFilmId.Font = new Font("Segoe UI", 14F);
            txtFilmId.Location = new Point(390, 17);
            txtFilmId.Name = "txtFilmId";
            txtFilmId.Size = new Size(226, 39);
            txtFilmId.TabIndex = 8;
            // 
            // btnOnay
            // 
            btnOnay.Anchor = AnchorStyles.Right;
            btnOnay.Font = new Font("Segoe UI", 14F);
            btnOnay.Location = new Point(639, 389);
            btnOnay.Name = "btnOnay";
            btnOnay.Size = new Size(133, 37);
            btnOnay.TabIndex = 5;
            btnOnay.Text = "Onayla";
            btnOnay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 169);
            label2.Name = "label2";
            label2.Size = new Size(171, 32);
            label2.TabIndex = 10;
            label2.Text = "Başlangıç Saati";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(3, 243);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 11;
            label4.Text = "Süre";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(3, 317);
            label5.Name = "label5";
            label5.Size = new Size(70, 32);
            label5.TabIndex = 12;
            label5.Text = "Ücret";
            // 
            // SeansTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(802, 603);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SeansTab";
            Text = "SeansTab";
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
        private TextBox txtSalonId;
        private Label Salon;
        private Label label3;
        private TextBox txtFilmId;
        private Button btnOnay;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtUcret;
        private TextBox txtSure;
        private TextBox textBaslangic;
    }
}