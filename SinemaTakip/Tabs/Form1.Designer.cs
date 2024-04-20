namespace SinemaTakip
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            Salon = new Label();
            label5 = new Label();
            btnSeans = new Button();
            label3 = new Label();
            btnSalon = new Button();
            btnFilm = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(778, 579);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.3972588F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.2054825F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.3972626F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(775, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(233, 27);
            label1.Name = "label1";
            label1.Size = new Size(308, 70);
            label1.TabIndex = 0;
            label1.Text = "Sinema seans takip uygulamasına hoş geldiniz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(3, 134);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(775, 52);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(439, 32);
            label2.TabIndex = 0;
            label2.Text = "Lütfen yapmak istediğiniz işlemi seçiniz:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(Salon, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(btnSeans, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(btnSalon, 1, 1);
            tableLayoutPanel2.Controls.Add(btnFilm, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 192);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(775, 387);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // Salon
            // 
            Salon.Anchor = AnchorStyles.Left;
            Salon.AutoSize = true;
            Salon.Font = new Font("Segoe UI", 14F);
            Salon.Location = new Point(3, 176);
            Salon.Name = "Salon";
            Salon.Size = new Size(122, 32);
            Salon.TabIndex = 1;
            Salon.Text = "Salon Tabı";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(3, 305);
            label5.Name = "label5";
            label5.Size = new Size(125, 32);
            label5.TabIndex = 2;
            label5.Text = "Seans Tabı";
            // 
            // btnSeans
            // 
            btnSeans.Anchor = AnchorStyles.None;
            btnSeans.Font = new Font("Segoe UI", 14F);
            btnSeans.Location = new Point(514, 303);
            btnSeans.Name = "btnSeans";
            btnSeans.Size = new Size(133, 37);
            btnSeans.TabIndex = 5;
            btnSeans.Text = "Seç";
            btnSeans.UseVisualStyleBackColor = true;
            btnSeans.Click += btnSeans_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 0;
            label3.Text = "Film Tabı";
            // 
            // btnSalon
            // 
            btnSalon.Anchor = AnchorStyles.None;
            btnSalon.Font = new Font("Segoe UI", 14F);
            btnSalon.Location = new Point(517, 173);
            btnSalon.Name = "btnSalon";
            btnSalon.Size = new Size(127, 37);
            btnSalon.TabIndex = 4;
            btnSalon.Text = "Seç";
            btnSalon.UseVisualStyleBackColor = true;
            btnSalon.Click += btnSalon_Click;
            // 
            // btnFilm
            // 
            btnFilm.Anchor = AnchorStyles.None;
            btnFilm.Font = new Font("Segoe UI", 14F);
            btnFilm.ForeColor = SystemColors.ControlText;
            btnFilm.Location = new Point(521, 47);
            btnFilm.Name = "btnFilm";
            btnFilm.Size = new Size(120, 34);
            btnFilm.TabIndex = 3;
            btnFilm.Text = "Seç";
            btnFilm.UseVisualStyleBackColor = true;
            btnFilm.Click += btnFilm_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(3, 585);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(250, 125);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(802, 603);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "AnaSayfa";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label Salon;
        private Label label5;
        private Button btnFilm;
        private Button btnSalon;
        private Button btnSeans;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}
