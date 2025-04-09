namespace GEM_Code_V2
{
    partial class Podiums
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
            this.lb_Classes = new System.Windows.Forms.ListBox();
            this.btn_LoadSelected = new System.Windows.Forms.Button();
            this.btn_LoadAll = new System.Windows.Forms.Button();
            this.btn_CloseAll = new System.Windows.Forms.Button();
            this.cb_Overall = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_Classes
            // 
            this.lb_Classes.FormattingEnabled = true;
            this.lb_Classes.ItemHeight = 16;
            this.lb_Classes.Location = new System.Drawing.Point(40, 40);
            this.lb_Classes.Name = "lb_Classes";
            this.lb_Classes.Size = new System.Drawing.Size(85, 116);
            this.lb_Classes.TabIndex = 0;
            // 
            // btn_LoadSelected
            // 
            this.btn_LoadSelected.Location = new System.Drawing.Point(40, 225);
            this.btn_LoadSelected.Name = "btn_LoadSelected";
            this.btn_LoadSelected.Size = new System.Drawing.Size(85, 50);
            this.btn_LoadSelected.TabIndex = 1;
            this.btn_LoadSelected.Text = "Load Selected";
            this.btn_LoadSelected.UseVisualStyleBackColor = true;
            this.btn_LoadSelected.Click += new System.EventHandler(this.btn_LoadSelected_Click);
            // 
            // btn_LoadAll
            // 
            this.btn_LoadAll.Location = new System.Drawing.Point(40, 280);
            this.btn_LoadAll.Name = "btn_LoadAll";
            this.btn_LoadAll.Size = new System.Drawing.Size(85, 50);
            this.btn_LoadAll.TabIndex = 2;
            this.btn_LoadAll.Text = "Load All Podiums";
            this.btn_LoadAll.UseVisualStyleBackColor = true;
            this.btn_LoadAll.Click += new System.EventHandler(this.btn_LoadAll_Click);
            // 
            // btn_CloseAll
            // 
            this.btn_CloseAll.Location = new System.Drawing.Point(40, 335);
            this.btn_CloseAll.Name = "btn_CloseAll";
            this.btn_CloseAll.Size = new System.Drawing.Size(85, 50);
            this.btn_CloseAll.TabIndex = 3;
            this.btn_CloseAll.Text = "Close All Podiums";
            this.btn_CloseAll.UseVisualStyleBackColor = true;
            this.btn_CloseAll.Click += new System.EventHandler(this.btn_CloseAll_Click);
            // 
            // cb_Overall
            // 
            this.cb_Overall.AutoSize = true;
            this.cb_Overall.Location = new System.Drawing.Point(40, 165);
            this.cb_Overall.Name = "cb_Overall";
            this.cb_Overall.Size = new System.Drawing.Size(77, 55);
            this.cb_Overall.TabIndex = 4;
            this.cb_Overall.Text = "Load\r\nOverall\r\nPodium";
            this.cb_Overall.UseVisualStyleBackColor = true;
            // 
            // Podiums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 403);
            this.Controls.Add(this.cb_Overall);
            this.Controls.Add(this.btn_CloseAll);
            this.Controls.Add(this.btn_LoadAll);
            this.Controls.Add(this.btn_LoadSelected);
            this.Controls.Add(this.lb_Classes);
            this.Name = "Podiums";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Classes;
        private System.Windows.Forms.Button btn_LoadSelected;
        private System.Windows.Forms.Button btn_LoadAll;
        private System.Windows.Forms.Button btn_CloseAll;
        private System.Windows.Forms.CheckBox cb_Overall;
    }
}