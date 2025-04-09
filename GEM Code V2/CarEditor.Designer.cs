namespace GEM_Code_V2
{
    partial class CarEditor
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
            this.tb_CN = new System.Windows.Forms.TextBox();
            this.tb_TNL = new System.Windows.Forms.TextBox();
            this.tb_CNL = new System.Windows.Forms.TextBox();
            this.tb_OVR = new System.Windows.Forms.TextBox();
            this.tb_CSL = new System.Windows.Forms.TextBox();
            this.tb_BOP = new System.Windows.Forms.TextBox();
            this.tb_TSL = new System.Windows.Forms.TextBox();
            this.tb_Reliability = new System.Windows.Forms.TextBox();
            this.btn_CreateCar = new System.Windows.Forms.Button();
            this.btn_DeleteCar = new System.Windows.Forms.Button();
            this.btn_UpdateCar = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_Classes = new System.Windows.Forms.ComboBox();
            this.tb_CLL = new System.Windows.Forms.TextBox();
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
            this.lb_ChooseCar.SelectedIndexChanged += new System.EventHandler(this.lb_ChooseCar_SelectedIndexChanged);
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
            // tb_CN
            // 
            this.tb_CN.Location = new System.Drawing.Point(240, 50);
            this.tb_CN.Name = "tb_CN";
            this.tb_CN.Size = new System.Drawing.Size(210, 22);
            this.tb_CN.TabIndex = 1;
            // 
            // tb_TNL
            // 
            this.tb_TNL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_TNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TNL.Location = new System.Drawing.Point(240, 30);
            this.tb_TNL.Name = "tb_TNL";
            this.tb_TNL.ReadOnly = true;
            this.tb_TNL.Size = new System.Drawing.Size(100, 15);
            this.tb_TNL.TabIndex = 0;
            this.tb_TNL.Text = "Car Name:";
            // 
            // tb_CNL
            // 
            this.tb_CNL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_CNL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CNL.Location = new System.Drawing.Point(240, 80);
            this.tb_CNL.Name = "tb_CNL";
            this.tb_CNL.ReadOnly = true;
            this.tb_CNL.Size = new System.Drawing.Size(100, 15);
            this.tb_CNL.TabIndex = 0;
            this.tb_CNL.Text = "Car OVR:";
            // 
            // tb_OVR
            // 
            this.tb_OVR.Location = new System.Drawing.Point(350, 80);
            this.tb_OVR.Name = "tb_OVR";
            this.tb_OVR.Size = new System.Drawing.Size(100, 22);
            this.tb_OVR.TabIndex = 2;
            // 
            // tb_CSL
            // 
            this.tb_CSL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_CSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CSL.Location = new System.Drawing.Point(240, 110);
            this.tb_CSL.Name = "tb_CSL";
            this.tb_CSL.ReadOnly = true;
            this.tb_CSL.Size = new System.Drawing.Size(100, 15);
            this.tb_CSL.TabIndex = 0;
            this.tb_CSL.Text = "Car BoP:";
            // 
            // tb_BOP
            // 
            this.tb_BOP.Location = new System.Drawing.Point(350, 110);
            this.tb_BOP.Name = "tb_BOP";
            this.tb_BOP.Size = new System.Drawing.Size(100, 22);
            this.tb_BOP.TabIndex = 3;
            // 
            // tb_TSL
            // 
            this.tb_TSL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_TSL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TSL.Location = new System.Drawing.Point(240, 140);
            this.tb_TSL.Name = "tb_TSL";
            this.tb_TSL.ReadOnly = true;
            this.tb_TSL.Size = new System.Drawing.Size(100, 15);
            this.tb_TSL.TabIndex = 0;
            this.tb_TSL.Text = "Car Reliability:";
            // 
            // tb_Reliability
            // 
            this.tb_Reliability.Location = new System.Drawing.Point(350, 140);
            this.tb_Reliability.Name = "tb_Reliability";
            this.tb_Reliability.Size = new System.Drawing.Size(100, 22);
            this.tb_Reliability.TabIndex = 4;
            // 
            // btn_CreateCar
            // 
            this.btn_CreateCar.Location = new System.Drawing.Point(360, 234);
            this.btn_CreateCar.Name = "btn_CreateCar";
            this.btn_CreateCar.Size = new System.Drawing.Size(90, 35);
            this.btn_CreateCar.TabIndex = 0;
            this.btn_CreateCar.Text = "Create Car";
            this.btn_CreateCar.UseVisualStyleBackColor = true;
            this.btn_CreateCar.Click += new System.EventHandler(this.btn_CreateCar_Click);
            // 
            // btn_DeleteCar
            // 
            this.btn_DeleteCar.Location = new System.Drawing.Point(360, 275);
            this.btn_DeleteCar.Name = "btn_DeleteCar";
            this.btn_DeleteCar.Size = new System.Drawing.Size(90, 35);
            this.btn_DeleteCar.TabIndex = 8;
            this.btn_DeleteCar.Text = "Delete Car";
            this.btn_DeleteCar.UseVisualStyleBackColor = true;
            this.btn_DeleteCar.Click += new System.EventHandler(this.btn_DeleteCar_Click);
            // 
            // btn_UpdateCar
            // 
            this.btn_UpdateCar.Location = new System.Drawing.Point(240, 234);
            this.btn_UpdateCar.Name = "btn_UpdateCar";
            this.btn_UpdateCar.Size = new System.Drawing.Size(110, 35);
            this.btn_UpdateCar.TabIndex = 9;
            this.btn_UpdateCar.Text = "Update Car";
            this.btn_UpdateCar.UseVisualStyleBackColor = true;
            this.btn_UpdateCar.Click += new System.EventHandler(this.btn_UpdateCar_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(240, 275);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 35);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_Classes
            // 
            this.cb_Classes.FormattingEnabled = true;
            this.cb_Classes.Location = new System.Drawing.Point(350, 170);
            this.cb_Classes.Name = "cb_Classes";
            this.cb_Classes.Size = new System.Drawing.Size(100, 24);
            this.cb_Classes.TabIndex = 7;
            // 
            // tb_CLL
            // 
            this.tb_CLL.BackColor = System.Drawing.SystemColors.Control;
            this.tb_CLL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_CLL.Location = new System.Drawing.Point(240, 170);
            this.tb_CLL.Name = "tb_CLL";
            this.tb_CLL.ReadOnly = true;
            this.tb_CLL.Size = new System.Drawing.Size(100, 15);
            this.tb_CLL.TabIndex = 0;
            this.tb_CLL.Text = "Car Class:";
            // 
            // CarEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 333);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_UpdateCar);
            this.Controls.Add(this.btn_DeleteCar);
            this.Controls.Add(this.btn_CreateCar);
            this.Controls.Add(this.tb_TSL);
            this.Controls.Add(this.tb_Reliability);
            this.Controls.Add(this.tb_CSL);
            this.Controls.Add(this.tb_BOP);
            this.Controls.Add(this.tb_CLL);
            this.Controls.Add(this.cb_Classes);
            this.Controls.Add(this.tb_CNL);
            this.Controls.Add(this.tb_OVR);
            this.Controls.Add(this.tb_TNL);
            this.Controls.Add(this.tb_CN);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btnLocateFile);
            this.Controls.Add(this.lb_ChooseCar);
            this.Name = "CarEditor";
            this.Text = "Car Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_ChooseCar;
        private System.Windows.Forms.OpenFileDialog FileLocator;
        private System.Windows.Forms.Button btnLocateFile;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox tb_CN;
        private System.Windows.Forms.TextBox tb_TNL;
        private System.Windows.Forms.TextBox tb_CNL;
        private System.Windows.Forms.TextBox tb_OVR;
        private System.Windows.Forms.TextBox tb_CSL;
        private System.Windows.Forms.TextBox tb_BOP;
        private System.Windows.Forms.TextBox tb_TSL;
        private System.Windows.Forms.TextBox tb_Reliability;
        private System.Windows.Forms.Button btn_CreateCar;
        private System.Windows.Forms.Button btn_DeleteCar;
        private System.Windows.Forms.Button btn_UpdateCar;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cb_Classes;
        private System.Windows.Forms.TextBox tb_CLL;
    }
}