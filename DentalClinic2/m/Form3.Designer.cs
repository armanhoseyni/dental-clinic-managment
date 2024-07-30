namespace DentalClinic2
{
    partial class frm_sn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sn));
            this.txt_sn = new System.Windows.Forms.TextBox();
            this.btn_chekSn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_sn
            // 
            this.txt_sn.Location = new System.Drawing.Point(210, 106);
            this.txt_sn.Name = "txt_sn";
            this.txt_sn.Size = new System.Drawing.Size(295, 22);
            this.txt_sn.TabIndex = 0;
            // 
            // btn_chekSn
            // 
            this.btn_chekSn.Location = new System.Drawing.Point(260, 160);
            this.btn_chekSn.Name = "btn_chekSn";
            this.btn_chekSn.Size = new System.Drawing.Size(188, 23);
            this.btn_chekSn.TabIndex = 1;
            this.btn_chekSn.Text = "Check Serial number";
            this.btn_chekSn.UseVisualStyleBackColor = true;
            this.btn_chekSn.Click += new System.EventHandler(this.btn_chekSn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter serial number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(668, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beta version has been ended please enter serial number to verify main version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_sn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_chekSn);
            this.Controls.Add(this.txt_sn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sn";
            this.Load += new System.EventHandler(this.frm_sn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sn;
        private System.Windows.Forms.Button btn_chekSn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}