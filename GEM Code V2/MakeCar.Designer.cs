﻿namespace GEM_Code_V2
{
    partial class MakeCar
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
            this.lb_ChooseCar = new System.Windows.Forms.ListBox();
            this.FileLocator = new System.Windows.Forms.OpenFileDialog();
            this.btnLocateFile = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tb_TN = new System.Windows.Forms.TextBox();
            this.tb_TNL = new System.Windows.Forms.TextBox();
            this.tb_CNL = new System.Windows.Forms.TextBox();
            this.tb_CN = new System.Windows.Forms.TextBox();
            this.cb_Classes = new System.Windows.Forms.ComboBox();
            this.tb_CLL = new System.Windows.Forms.TextBox();
            this.tb_CSL = new System.Windows.Forms.TextBox();
            this.tb_CS = new System.Windows.Forms.TextBox();
            this.tb_TSL = new System.Windows.Forms.TextBox();
            this.tb_TS = new System.Windows.Forms.TextBox();
            this.btn_MakeCar = new System.Windows.Forms.Button();
            this.tb_CRL = new System.Windows.Forms.TextBox();
            this.tb_CR = new System.Windows.Forms.TextBox();
            this.tb_SRML = new System.Windows.Forms.TextBox();
            this.tb_SRM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_ChooseCar
            // 
            this.lb_ChooseCar.FormattingEnabled = true;
            this.lb_ChooseCar.ItemHeight = 16;
            this.lb_ChooseCar.Location = new System.Drawing.Point(25, 25);
            this.lb_ChooseCar.Name = "lb_ChooseCar";
            this.lb_ChooseCar.Size = new System.Drawing.Size(200, 244);
            this.lb_ChooseCar.TabIndex = 0;
            // 
            // FileLocator
            // 
            this.FileLocator.FileName = "FileLocator";
            // 
            // btnLocateFile
            // 
            this.btnLocateFile.Location = new System.Drawing.Point(25, 275);
            this.btnLocateFile.Name = "btnLocateFile";
            this.btnLocateFile.Size = new System.Drawing.Size(130, 35);
            this.btnLocateFile.TabIndex = 0;
            this.btnLocateFile.Text = "Locate File";
            this.btnLocateFile.UseVisualStyleBackColor = true;
            this.btnLocateFile.Click += new System.EventHandler(this.btnLocateFile_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(161, 275);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(64, 35);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tb_TN
            // 
            this.tb_TN.Location = new System.Drawing.Point(250, 50);
            this.tb_TN.Name = "tb_TN";
            this.tb_TN.Size = new System.Drawing.Size(200, 22);
            this.tb_TN.TabIndex = 1;
            // 
            // tb_TNL
            // 
            this.tb_TNL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_TNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TNL.Location = new System.Drawing.Point(250, 30);
            this.tb_TNL.Name = "tb_TNL";
            this.tb_TNL.ReadOnly = true;
            this.tb_TNL.Size = new System.Drawing.Size(100, 15);
            this.tb_TNL.TabIndex = 0;
            this.tb_TNL.Text = "Team Name:";
            // 
            // tb_CNL
            // 
            this.tb_CNL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_CNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CNL.Location = new System.Drawing.Point(250, 80);
            this.tb_CNL.Name = "tb_CNL";
            this.tb_CNL.ReadOnly = true;
            this.tb_CNL.Size = new System.Drawing.Size(100, 15);
            this.tb_CNL.TabIndex = 0;
            this.tb_CNL.Text = "Crew Number:";
            // 
            // tb_CN
            // 
            this.tb_CN.Location = new System.Drawing.Point(360, 80);
            this.tb_CN.Name = "tb_CN";
            this.tb_CN.Size = new System.Drawing.Size(90, 22);
            this.tb_CN.TabIndex = 2;
            // 
            // cb_Classes
            // 
            this.cb_Classes.FormattingEnabled = true;
            this.cb_Classes.Location = new System.Drawing.Point(360, 230);
            this.cb_Classes.Name = "cb_Classes";
            this.cb_Classes.Size = new System.Drawing.Size(90, 24);
            this.cb_Classes.TabIndex = 7;
            // 
            // tb_CLL
            // 
            this.tb_CLL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_CLL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CLL.Location = new System.Drawing.Point(250, 230);
            this.tb_CLL.Name = "tb_CLL";
            this.tb_CLL.ReadOnly = true;
            this.tb_CLL.Size = new System.Drawing.Size(100, 15);
            this.tb_CLL.TabIndex = 0;
            this.tb_CLL.Text = "Car Class:";
            // 
            // tb_CSL
            // 
            this.tb_CSL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_CSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CSL.Location = new System.Drawing.Point(250, 110);
            this.tb_CSL.Name = "tb_CSL";
            this.tb_CSL.ReadOnly = true;
            this.tb_CSL.Size = new System.Drawing.Size(100, 15);
            this.tb_CSL.TabIndex = 0;
            this.tb_CSL.Text = "Crew Score:";
            // 
            // tb_CS
            // 
            this.tb_CS.Location = new System.Drawing.Point(360, 110);
            this.tb_CS.Name = "tb_CS";
            this.tb_CS.Size = new System.Drawing.Size(90, 22);
            this.tb_CS.TabIndex = 3;
            // 
            // tb_TSL
            // 
            this.tb_TSL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_TSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TSL.Location = new System.Drawing.Point(250, 140);
            this.tb_TSL.Name = "tb_TSL";
            this.tb_TSL.ReadOnly = true;
            this.tb_TSL.Size = new System.Drawing.Size(100, 15);
            this.tb_TSL.TabIndex = 0;
            this.tb_TSL.Text = "Team Score:";
            // 
            // tb_TS
            // 
            this.tb_TS.Location = new System.Drawing.Point(360, 140);
            this.tb_TS.Name = "tb_TS";
            this.tb_TS.Size = new System.Drawing.Size(90, 22);
            this.tb_TS.TabIndex = 4;
            // 
            // btn_MakeCar
            // 
            this.btn_MakeCar.Location = new System.Drawing.Point(250, 275);
            this.btn_MakeCar.Name = "btn_MakeCar";
            this.btn_MakeCar.Size = new System.Drawing.Size(200, 35);
            this.btn_MakeCar.TabIndex = 0;
            this.btn_MakeCar.Text = "Make Car";
            this.btn_MakeCar.UseVisualStyleBackColor = true;
            this.btn_MakeCar.Click += new System.EventHandler(this.btn_MakeCar_Click);
            // 
            // tb_CRL
            // 
            this.tb_CRL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_CRL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CRL.Location = new System.Drawing.Point(250, 170);
            this.tb_CRL.Name = "tb_CRL";
            this.tb_CRL.ReadOnly = true;
            this.tb_CRL.ShortcutsEnabled = false;
            this.tb_CRL.Size = new System.Drawing.Size(100, 15);
            this.tb_CRL.TabIndex = 0;
            this.tb_CRL.Text = "Crew Reliability:";
            // 
            // tb_CR
            // 
            this.tb_CR.Location = new System.Drawing.Point(360, 170);
            this.tb_CR.Name = "tb_CR";
            this.tb_CR.Size = new System.Drawing.Size(90, 22);
            this.tb_CR.TabIndex = 5;
            // 
            // tb_SRML
            // 
            this.tb_SRML.BackColor = System.Drawing.SystemColors.Control;
            this.tb_SRML.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SRML.Location = new System.Drawing.Point(250, 200);
            this.tb_SRML.Name = "tb_SRML";
            this.tb_SRML.ReadOnly = true;
            this.tb_SRML.Size = new System.Drawing.Size(100, 15);
            this.tb_SRML.TabIndex = 0;
            this.tb_SRML.Text = "Stint Modifier:";
            // 
            // tb_SRM
            // 
            this.tb_SRM.Location = new System.Drawing.Point(360, 200);
            this.tb_SRM.Name = "tb_SRM";
            this.tb_SRM.Size = new System.Drawing.Size(90, 22);
            this.tb_SRM.TabIndex = 6;
            // 
            // MakeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 333);
            this.Controls.Add(this.tb_SRML);
            this.Controls.Add(this.tb_SRM);
            this.Controls.Add(this.tb_CRL);
            this.Controls.Add(this.tb_CR);
            this.Controls.Add(this.btn_MakeCar);
            this.Controls.Add(this.tb_TSL);
            this.Controls.Add(this.tb_TS);
            this.Controls.Add(this.tb_CSL);
            this.Controls.Add(this.tb_CS);
            this.Controls.Add(this.tb_CLL);
            this.Controls.Add(this.cb_Classes);
            this.Controls.Add(this.tb_CNL);
            this.Controls.Add(this.tb_CN);
            this.Controls.Add(this.tb_TNL);
            this.Controls.Add(this.tb_TN);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btnLocateFile);
            this.Controls.Add(this.lb_ChooseCar);
            this.Name = "MakeCar";
            this.Text = "Car Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_ChooseCar;
        private System.Windows.Forms.OpenFileDialog FileLocator;
        private System.Windows.Forms.Button btnLocateFile;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox tb_TN;
        private System.Windows.Forms.TextBox tb_TNL;
        private System.Windows.Forms.TextBox tb_CNL;
        private System.Windows.Forms.TextBox tb_CN;
        private System.Windows.Forms.ComboBox cb_Classes;
        private System.Windows.Forms.TextBox tb_CLL;
        private System.Windows.Forms.TextBox tb_CSL;
        private System.Windows.Forms.TextBox tb_CS;
        private System.Windows.Forms.TextBox tb_TSL;
        private System.Windows.Forms.TextBox tb_TS;
        private System.Windows.Forms.Button btn_MakeCar;
        private System.Windows.Forms.TextBox tb_CRL;
        private System.Windows.Forms.TextBox tb_CR;
        private System.Windows.Forms.TextBox tb_SRML;
        private System.Windows.Forms.TextBox tb_SRM;
    }
}