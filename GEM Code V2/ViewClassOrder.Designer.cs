namespace GEM_Code_V2
{
    partial class ViewClassOrder
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
            this.btn_CloseAll = new System.Windows.Forms.Button();
            this.btn_LoadAll = new System.Windows.Forms.Button();
            this.btn_LoadSelected = new System.Windows.Forms.Button();
            this.lb_Classes = new System.Windows.Forms.ListBox();
            this.cb_Overall = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_CloseAll
            // 
            this.btn_CloseAll.Location = new System.Drawing.Point(40, 335);
            this.btn_CloseAll.Name = "btn_CloseAll";
            this.btn_CloseAll.Size = new System.Drawing.Size(85, 50);
            this.btn_CloseAll.TabIndex = 7;
            this.btn_CloseAll.Text = "Close All Classes";
            this.btn_CloseAll.UseVisualStyleBackColor = true;
            this.btn_CloseAll.Click += new System.EventHandler(this.btn_CloseAll_Click);
            // 
            // btn_LoadAll
            // 
            this.btn_LoadAll.Location = new System.Drawing.Point(40, 280);
            this.btn_LoadAll.Name = "btn_LoadAll";
            this.btn_LoadAll.Size = new System.Drawing.Size(85, 50);
            this.btn_LoadAll.TabIndex = 6;
            this.btn_LoadAll.Text = "Load All Classes";
            this.btn_LoadAll.UseVisualStyleBackColor = true;
            this.btn_LoadAll.Click += new System.EventHandler(this.btn_LoadAll_Click);
            // 
            // btn_LoadSelected
            // 
            this.btn_LoadSelected.Location = new System.Drawing.Point(40, 225);
            this.btn_LoadSelected.Name = "btn_LoadSelected";
            this.btn_LoadSelected.Size = new System.Drawing.Size(85, 50);
            this.btn_LoadSelected.TabIndex = 5;
            this.btn_LoadSelected.Text = "Load Selected";
            this.btn_LoadSelected.UseVisualStyleBackColor = true;
            this.btn_LoadSelected.Click += new System.EventHandler(this.btn_LoadSelected_Click);
            // 
            // lb_Classes
            // 
            this.lb_Classes.FormattingEnabled = true;
            this.lb_Classes.ItemHeight = 16;
            this.lb_Classes.Location = new System.Drawing.Point(40, 40);
            this.lb_Classes.Name = "lb_Classes";
            this.lb_Classes.Size = new System.Drawing.Size(85, 116);
            this.lb_Classes.TabIndex = 4;
            // 
            // cb_Overall
            // 
            this.cb_Overall.AutoSize = true;
            this.cb_Overall.Location = new System.Drawing.Point(40, 165);
            this.cb_Overall.Name = "cb_Overall";
            this.cb_Overall.Size = new System.Drawing.Size(77, 55);
            this.cb_Overall.TabIndex = 8;
            this.cb_Overall.Text = "Load\r\nOverall\r\nTop 8\'s";
            this.cb_Overall.UseVisualStyleBackColor = true;
            // 
            // ViewClassOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 403);
            this.Controls.Add(this.cb_Overall);
            this.Controls.Add(this.btn_CloseAll);
            this.Controls.Add(this.btn_LoadAll);
            this.Controls.Add(this.btn_LoadSelected);
            this.Controls.Add(this.lb_Classes);
            this.Name = "ViewClassOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CloseAll;
        private System.Windows.Forms.Button btn_LoadAll;
        private System.Windows.Forms.Button btn_LoadSelected;
        private System.Windows.Forms.ListBox lb_Classes;
        private System.Windows.Forms.CheckBox cb_Overall;
    }
}