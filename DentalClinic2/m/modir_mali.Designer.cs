namespace DentalClinic2.m
{
    partial class modir_mali
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
            this.components = new System.ComponentModel.Container();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend1 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend2 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend3 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modir_mali));
            this.dataGridViewFinancial = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_chap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bedehi = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.txt_takhfif = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.txt_Pardakht = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.txt_LastPrice = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_bargasht = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinancial)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bargasht)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFinancial
            // 
            this.dataGridViewFinancial.AllowUserToAddRows = false;
            this.dataGridViewFinancial.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridViewFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinancial.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewFinancial.Name = "dataGridViewFinancial";
            this.dataGridViewFinancial.RowHeadersWidth = 51;
            this.dataGridViewFinancial.RowTemplate.Height = 24;
            this.dataGridViewFinancial.Size = new System.Drawing.Size(709, 241);
            this.dataGridViewFinancial.TabIndex = 0;
            this.dataGridViewFinancial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFinancial_CellContentClick);
            this.dataGridViewFinancial.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFinancial_RowEnter);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(223, 150);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(87, 40);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_chap
            // 
            this.btn_chap.Location = new System.Drawing.Point(348, 151);
            this.btn_chap.Name = "btn_chap";
            this.btn_chap.Size = new System.Drawing.Size(114, 39);
            this.btn_chap.TabIndex = 3;
            this.btn_chap.Text = "print";
            this.btn_chap.UseVisualStyleBackColor = true;
            this.btn_chap.Click += new System.EventHandler(this.btn_chap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_bedehi);
            this.groupBox1.Controls.Add(this.txt_takhfif);
            this.groupBox1.Controls.Add(this.txt_Pardakht);
            this.groupBox1.Controls.Add(this.txt_LastPrice);
            this.groupBox1.Controls.Add(this.btn_chap);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(77, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Debt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(551, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fixed Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(384, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Main Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(243, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Discount";
            // 
            // txt_bedehi
            // 
            this.txt_bedehi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bedehi.Location = new System.Drawing.Point(35, 82);
            this.txt_bedehi.Multiline = true;
            this.txt_bedehi.Name = "txt_bedehi";
            this.txt_bedehi.Size = new System.Drawing.Size(127, 36);
            this.txt_bedehi.TabIndex = 9;
            this.txt_bedehi.WaterMark = "";
            this.txt_bedehi.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txt_bedehi.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bedehi.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.txt_bedehi.TextChanged += new System.EventHandler(this.txt_bedehi_TextChanged);
            // 
            // txt_takhfif
            // 
            this.txt_takhfif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_takhfif.Location = new System.Drawing.Point(200, 82);
            this.txt_takhfif.Multiline = true;
            this.txt_takhfif.Name = "txt_takhfif";
            this.txt_takhfif.Size = new System.Drawing.Size(127, 36);
            this.txt_takhfif.TabIndex = 8;
            this.txt_takhfif.WaterMark = "";
            this.txt_takhfif.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txt_takhfif.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_takhfif.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.txt_takhfif.TextChanged += new System.EventHandler(this.txt_takhfif_TextChanged);
            // 
            // txt_Pardakht
            // 
            this.txt_Pardakht.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pardakht.Location = new System.Drawing.Point(365, 82);
            this.txt_Pardakht.Name = "txt_Pardakht";
            this.txt_Pardakht.Size = new System.Drawing.Size(127, 36);
            this.txt_Pardakht.TabIndex = 7;
            this.txt_Pardakht.WaterMark = "";
            this.txt_Pardakht.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txt_Pardakht.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pardakht.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.txt_Pardakht.TextChanged += new System.EventHandler(this.txt_Pardakht_TextChanged);
            // 
            // txt_LastPrice
            // 
            this.txt_LastPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastPrice.Location = new System.Drawing.Point(527, 82);
            this.txt_LastPrice.Name = "txt_LastPrice";
            this.txt_LastPrice.Size = new System.Drawing.Size(127, 36);
            this.txt_LastPrice.TabIndex = 6;
            this.txt_LastPrice.WaterMark = "";
            this.txt_LastPrice.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.txt_LastPrice.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastPrice.WaterMarkForeColor = System.Drawing.Color.LightGray;
            this.txt_LastPrice.TextChanged += new System.EventHandler(this.DateID_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackColor = System.Drawing.Color.Crimson;
            this.btn_exit.Location = new System.Drawing.Point(21, 504);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(134, 41);
            this.btn_exit.TabIndex = 29;
            this.btn_exit.Text = "Log out";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_bargasht
            // 
            this.btn_bargasht.BackgroundStyle.GradientEndColor = System.Drawing.Color.BurlyWood;
            this.btn_bargasht.BackgroundStyle.GradientStartColor = System.Drawing.Color.NavajoWhite;
            this.btn_bargasht.BorderStyle.EdgeRadius = 10;
            this.btn_bargasht.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btn_bargasht.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_bargasht.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_bargasht.DropDownArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_bargasht.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_bargasht.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_bargasht.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bargasht.Location = new System.Drawing.Point(21, 504);
            this.btn_bargasht.Name = "btn_bargasht";
            this.btn_bargasht.Size = new System.Drawing.Size(134, 40);
            this.btn_bargasht.StateStyles.FocusStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_bargasht.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.BurlyWood;
            gradientBlend1.Factor = 0F;
            gradientBlend1.Position = 0F;
            gradientBlend2.Factor = 0F;
            gradientBlend2.Position = 0.5F;
            gradientBlend3.Factor = 1F;
            gradientBlend3.Position = 1F;
            this.btn_bargasht.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend1);
            this.btn_bargasht.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend2);
            this.btn_bargasht.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend3);
            this.btn_bargasht.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.NavajoWhite;
            this.btn_bargasht.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.BurlyWood;
            this.btn_bargasht.TabIndex = 30;
            this.btn_bargasht.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_bargasht.TextStyle.Text = "Return to Home";
            this.btn_bargasht.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bargasht.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_bargasht.Click += new System.EventHandler(this.btn_bargasht_Click_1);
            // 
            // modir_mali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(736, 549);
            this.Controls.Add(this.btn_bargasht);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewFinancial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modir_mali";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت مالی";
            this.Load += new System.EventHandler(this.modir_mali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinancial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bargasht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFinancial;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_chap;
        private System.Windows.Forms.GroupBox groupBox1;
        private ChreneLib.Controls.TextBoxes.CTextBox txt_bedehi;
        private ChreneLib.Controls.TextBoxes.CTextBox txt_takhfif;
        private ChreneLib.Controls.TextBoxes.CTextBox txt_Pardakht;
        private ChreneLib.Controls.TextBoxes.CTextBox txt_LastPrice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_bargasht;
    }
}