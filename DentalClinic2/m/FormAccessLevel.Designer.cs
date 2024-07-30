namespace DentalClinic2.m
{
    partial class FormAccessLevel
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
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle1 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend1 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend2 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend3 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend4 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend5 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            Klik.Windows.Forms.v1.Common.GradientBlend gradientBlend6 = new Klik.Windows.Forms.v1.Common.GradientBlend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccessLevel));
            this.dataGridViewMoreinfoPer = new System.Windows.Forms.DataGridView();
            this.elLabel1 = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.txt_Pcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Pusername = new System.Windows.Forms.TextBox();
            this.cmb_AccessLevel = new System.Windows.Forms.ComboBox();
            this.txt_accesslevelU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DefineAccessLevel = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_bargasht = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoreinfoPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DefineAccessLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bargasht)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMoreinfoPer
            // 
            this.dataGridViewMoreinfoPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoreinfoPer.Location = new System.Drawing.Point(15, 4);
            this.dataGridViewMoreinfoPer.Name = "dataGridViewMoreinfoPer";
            this.dataGridViewMoreinfoPer.RowHeadersWidth = 51;
            this.dataGridViewMoreinfoPer.RowTemplate.Height = 24;
            this.dataGridViewMoreinfoPer.Size = new System.Drawing.Size(754, 212);
            this.dataGridViewMoreinfoPer.TabIndex = 0;
            this.dataGridViewMoreinfoPer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMoreinfoPer_RowEnter);
            // 
            // elLabel1
            // 
            this.elLabel1.BackgroundStyle.GradientEndColor = System.Drawing.Color.MidnightBlue;
            this.elLabel1.BackgroundStyle.GradientStartColor = System.Drawing.Color.RoyalBlue;
            this.elLabel1.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.elLabel1.BorderStyle.SolidColor = System.Drawing.Color.Navy;
            this.elLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            paintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle1.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elLabel1.FlashStyle = paintStyle1;
            this.elLabel1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.elLabel1.Location = new System.Drawing.Point(42, 222);
            this.elLabel1.Name = "elLabel1";
            this.elLabel1.Size = new System.Drawing.Size(692, 33);
            this.elLabel1.TabIndex = 1;
            this.elLabel1.TabStop = false;
            this.elLabel1.TextStyle.BackColor = System.Drawing.Color.Black;
            this.elLabel1.TextStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.elLabel1.TextStyle.ForeColor = System.Drawing.Color.White;
            this.elLabel1.TextStyle.Text = "Select a specific personnel to determine the access level";
            this.elLabel1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elLabel1.TextStyle.TextType = Klik.Windows.Forms.v1.Common.TextTypes.BlockShadow;
            this.elLabel1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // txt_Pcode
            // 
            this.txt_Pcode.Location = new System.Drawing.Point(402, 284);
            this.txt_Pcode.Name = "txt_Pcode";
            this.txt_Pcode.Size = new System.Drawing.Size(100, 22);
            this.txt_Pcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 287);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 287);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Username:";
            // 
            // txt_Pusername
            // 
            this.txt_Pusername.Location = new System.Drawing.Point(669, 282);
            this.txt_Pusername.Name = "txt_Pusername";
            this.txt_Pusername.Size = new System.Drawing.Size(100, 22);
            this.txt_Pusername.TabIndex = 5;
            // 
            // cmb_AccessLevel
            // 
            this.cmb_AccessLevel.FormattingEnabled = true;
            this.cmb_AccessLevel.Location = new System.Drawing.Point(402, 335);
            this.cmb_AccessLevel.Name = "cmb_AccessLevel";
            this.cmb_AccessLevel.Size = new System.Drawing.Size(121, 24);
            this.cmb_AccessLevel.TabIndex = 6;
            // 
            // txt_accesslevelU
            // 
            this.txt_accesslevelU.Location = new System.Drawing.Point(145, 287);
            this.txt_accesslevelU.Name = "txt_accesslevelU";
            this.txt_accesslevelU.Size = new System.Drawing.Size(100, 22);
            this.txt_accesslevelU.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Access Level Code:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(242, 338);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "New Access Level:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_DefineAccessLevel
            // 
            this.btn_DefineAccessLevel.BackgroundStyle.GradientEndColor = System.Drawing.Color.LimeGreen;
            this.btn_DefineAccessLevel.BackgroundStyle.GradientStartColor = System.Drawing.Color.PaleGreen;
            this.btn_DefineAccessLevel.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_DefineAccessLevel.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_DefineAccessLevel.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_DefineAccessLevel.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_DefineAccessLevel.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.DoubleSolid;
            this.btn_DefineAccessLevel.BorderStyle.EdgeRadius = 7;
            this.btn_DefineAccessLevel.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias;
            this.btn_DefineAccessLevel.BorderStyle.SolidColor = System.Drawing.Color.Green;
            this.btn_DefineAccessLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_DefineAccessLevel.DropDownArrowColor = System.Drawing.Color.Green;
            this.btn_DefineAccessLevel.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_DefineAccessLevel.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_DefineAccessLevel.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DefineAccessLevel.Location = new System.Drawing.Point(320, 384);
            this.btn_DefineAccessLevel.Name = "btn_DefineAccessLevel";
            this.btn_DefineAccessLevel.Size = new System.Drawing.Size(143, 45);
            this.btn_DefineAccessLevel.StateStyles.FocusStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_DefineAccessLevel.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.LimeGreen;
            gradientBlend1.Factor = 0F;
            gradientBlend1.Position = 0F;
            gradientBlend2.Factor = 0F;
            gradientBlend2.Position = 0.5F;
            gradientBlend3.Factor = 1F;
            gradientBlend3.Position = 1F;
            this.btn_DefineAccessLevel.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend1);
            this.btn_DefineAccessLevel.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend2);
            this.btn_DefineAccessLevel.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend3);
            this.btn_DefineAccessLevel.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.PaleGreen;
            this.btn_DefineAccessLevel.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.LimeGreen;
            this.btn_DefineAccessLevel.TabIndex = 10;
            this.btn_DefineAccessLevel.TextStyle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_DefineAccessLevel.TextStyle.Text = "Define";
            this.btn_DefineAccessLevel.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DefineAccessLevel.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_DefineAccessLevel.Click += new System.EventHandler(this.btn_DefineAccessLevel_Click);
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
            this.btn_bargasht.Location = new System.Drawing.Point(56, 418);
            this.btn_bargasht.Name = "btn_bargasht";
            this.btn_bargasht.Size = new System.Drawing.Size(150, 32);
            this.btn_bargasht.StateStyles.FocusStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_bargasht.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.BurlyWood;
            gradientBlend4.Factor = 0F;
            gradientBlend4.Position = 0F;
            gradientBlend5.Factor = 0F;
            gradientBlend5.Position = 0.5F;
            gradientBlend6.Factor = 1F;
            gradientBlend6.Position = 1F;
            this.btn_bargasht.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend4);
            this.btn_bargasht.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend5);
            this.btn_bargasht.StateStyles.HoverStyle.BackgroundGradientBlend.Add(gradientBlend6);
            this.btn_bargasht.StateStyles.PressedStyle.BackgroundGradientEndColor = System.Drawing.Color.NavajoWhite;
            this.btn_bargasht.StateStyles.PressedStyle.BackgroundGradientStartColor = System.Drawing.Color.BurlyWood;
            this.btn_bargasht.TabIndex = 11;
            this.btn_bargasht.TextStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_bargasht.TextStyle.Text = "Retun to Home";
            this.btn_bargasht.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bargasht.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_bargasht.Click += new System.EventHandler(this.btn_bargasht_Click);
            // 
            // FormAccessLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 473);
            this.Controls.Add(this.btn_bargasht);
            this.Controls.Add(this.btn_DefineAccessLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_accesslevelU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_AccessLevel);
            this.Controls.Add(this.txt_Pusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pcode);
            this.Controls.Add(this.elLabel1);
            this.Controls.Add(this.dataGridViewMoreinfoPer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAccessLevel";
            this.Text = "سطح دسترسی";
            this.Load += new System.EventHandler(this.FormAccessLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoreinfoPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DefineAccessLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_bargasht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMoreinfoPer;
        private Klik.Windows.Forms.v1.EntryLib.ELLabel elLabel1;
        private System.Windows.Forms.TextBox txt_Pcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Pusername;
        private System.Windows.Forms.ComboBox cmb_AccessLevel;
        private System.Windows.Forms.TextBox txt_accesslevelU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_DefineAccessLevel;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_bargasht;
    }
}