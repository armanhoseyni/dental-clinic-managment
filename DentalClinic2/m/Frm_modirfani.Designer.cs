namespace DentalClinic2.m
{
    partial class Frm_modirfani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_modirfani));
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_DocFullname = new System.Windows.Forms.TextBox();
            this.cmb_clock = new System.Windows.Forms.ComboBox();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.btn_ViewTable = new System.Windows.Forms.Button();
            this.btn_ViewDoctors = new System.Windows.Forms.Button();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.cmb_date = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_bargasht = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bargasht)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(510, 498);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(133, 45);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Submit";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_DocFullname
            // 
            this.txt_DocFullname.Location = new System.Drawing.Point(516, 431);
            this.txt_DocFullname.Name = "txt_DocFullname";
            this.txt_DocFullname.Size = new System.Drawing.Size(127, 22);
            this.txt_DocFullname.TabIndex = 1;
            // 
            // cmb_clock
            // 
            this.cmb_clock.FormattingEnabled = true;
            this.cmb_clock.Location = new System.Drawing.Point(602, 401);
            this.cmb_clock.Name = "cmb_clock";
            this.cmb_clock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_clock.Size = new System.Drawing.Size(153, 24);
            this.cmb_clock.TabIndex = 2;
            this.cmb_clock.Text = "ساعت";
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.Size = new System.Drawing.Size(1149, 315);
            this.dataGridViewTable.TabIndex = 3;
            this.dataGridViewTable.Visible = false;
            this.dataGridViewTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTable_RowEnter);
            // 
            // btn_ViewTable
            // 
            this.btn_ViewTable.Location = new System.Drawing.Point(980, 515);
            this.btn_ViewTable.Name = "btn_ViewTable";
            this.btn_ViewTable.Size = new System.Drawing.Size(158, 23);
            this.btn_ViewTable.TabIndex = 4;
            this.btn_ViewTable.Text = "DoctorsWork time table";
            this.btn_ViewTable.UseVisualStyleBackColor = true;
            this.btn_ViewTable.Click += new System.EventHandler(this.btn_ViewTable_Click);
            // 
            // btn_ViewDoctors
            // 
            this.btn_ViewDoctors.Location = new System.Drawing.Point(486, 459);
            this.btn_ViewDoctors.Name = "btn_ViewDoctors";
            this.btn_ViewDoctors.Size = new System.Drawing.Size(180, 26);
            this.btn_ViewDoctors.TabIndex = 5;
            this.btn_ViewDoctors.Text = "Doctors Table";
            this.btn_ViewDoctors.UseVisualStyleBackColor = true;
            this.btn_ViewDoctors.Click += new System.EventHandler(this.btn_ViewDoctors_Click);
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.RowHeadersWidth = 51;
            this.dataGridViewDoctors.RowTemplate.Height = 24;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(1149, 315);
            this.dataGridViewDoctors.TabIndex = 6;
            this.dataGridViewDoctors.Visible = false;
            this.dataGridViewDoctors.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctors_RowEnter);
            // 
            // cmb_date
            // 
            this.cmb_date.FormattingEnabled = true;
            this.cmb_date.Location = new System.Drawing.Point(396, 401);
            this.cmb_date.Name = "cmb_date";
            this.cmb_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_date.Size = new System.Drawing.Size(161, 24);
            this.cmb_date.TabIndex = 7;
            this.cmb_date.Text = "روز";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btn_bargasht.Location = new System.Drawing.Point(21, 511);
            this.btn_bargasht.Name = "btn_bargasht";
            this.btn_bargasht.Size = new System.Drawing.Size(150, 32);
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
            this.btn_bargasht.TabIndex = 8;
            this.btn_bargasht.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_bargasht.TextStyle.Text = "Return to Home";
            this.btn_bargasht.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bargasht.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_bargasht.Click += new System.EventHandler(this.btn_bargasht_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(1053, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select the desired doctor from the list of doctors and then determine the working" +
    " hours for the doctor by obtaining the appropriate time";
            // 
            // Frm_modirfani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1164, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bargasht);
            this.Controls.Add(this.cmb_date);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.btn_ViewDoctors);
            this.Controls.Add(this.btn_ViewTable);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.cmb_clock);
            this.Controls.Add(this.txt_DocFullname);
            this.Controls.Add(this.btn_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_modirfani";
            this.Text = "مدیریت فنی";
            this.Load += new System.EventHandler(this.Frm_modirfani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bargasht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_DocFullname;
        private System.Windows.Forms.ComboBox cmb_clock;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Button btn_ViewTable;
        private System.Windows.Forms.Button btn_ViewDoctors;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.ComboBox cmb_date;
        private System.Windows.Forms.Timer timer1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_bargasht;
        private System.Windows.Forms.Label label1;
    }
}