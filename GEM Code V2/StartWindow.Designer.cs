namespace GEM_Code_V2
{
    partial class StartWindow
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
            this.lb_Calendar = new System.Windows.Forms.ListBox();
            this.btn_ChooseRnd = new System.Windows.Forms.Button();
            this.btn_CreateCrew = new System.Windows.Forms.Button();
            this.FileLocater = new System.Windows.Forms.OpenFileDialog();
            this.FolderLocater = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_CreateCar = new System.Windows.Forms.Button();
            this.btn_DeleteAllCrews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Calendar
            // 
            this.lb_Calendar.FormattingEnabled = true;
            this.lb_Calendar.ItemHeight = 16;
            this.lb_Calendar.Location = new System.Drawing.Point(25, 25);
            this.lb_Calendar.Name = "lb_Calendar";
            this.lb_Calendar.Size = new System.Drawing.Size(200, 244);
            this.lb_Calendar.TabIndex = 0;
            // 
            // btn_ChooseRnd
            // 
            this.btn_ChooseRnd.Location = new System.Drawing.Point(25, 295);
            this.btn_ChooseRnd.Name = "btn_ChooseRnd";
            this.btn_ChooseRnd.Size = new System.Drawing.Size(200, 40);
            this.btn_ChooseRnd.TabIndex = 1;
            this.btn_ChooseRnd.Text = "Select Race";
            this.btn_ChooseRnd.UseVisualStyleBackColor = true;
            this.btn_ChooseRnd.Click += new System.EventHandler(this.btn_ChooseRnd_Click);
            // 
            // btn_CreateCrew
            // 
            this.btn_CreateCrew.Location = new System.Drawing.Point(25, 345);
            this.btn_CreateCrew.Name = "btn_CreateCrew";
            this.btn_CreateCrew.Size = new System.Drawing.Size(200, 40);
            this.btn_CreateCrew.TabIndex = 2;
            this.btn_CreateCrew.Text = "Create Crew";
            this.btn_CreateCrew.UseVisualStyleBackColor = true;
            this.btn_CreateCrew.Click += new System.EventHandler(this.btn_CreateCrew_Click);
            // 
            // FileLocater
            // 
            this.FileLocater.FileName = "openFileDialog1";
            // 
            // btn_CreateCar
            // 
            this.btn_CreateCar.Location = new System.Drawing.Point(135, 395);
            this.btn_CreateCar.Name = "btn_CreateCar";
            this.btn_CreateCar.Size = new System.Drawing.Size(90, 50);
            this.btn_CreateCar.TabIndex = 3;
            this.btn_CreateCar.Text = "Create Car";
            this.btn_CreateCar.UseVisualStyleBackColor = true;
            this.btn_CreateCar.Click += new System.EventHandler(this.btn_CreateCar_Click);
            // 
            // btn_DeleteAllCrews
            // 
            this.btn_DeleteAllCrews.Location = new System.Drawing.Point(25, 395);
            this.btn_DeleteAllCrews.Name = "btn_DeleteAllCrews";
            this.btn_DeleteAllCrews.Size = new System.Drawing.Size(90, 50);
            this.btn_DeleteAllCrews.TabIndex = 4;
            this.btn_DeleteAllCrews.Text = "Delete Crews";
            this.btn_DeleteAllCrews.UseVisualStyleBackColor = true;
            this.btn_DeleteAllCrews.Click += new System.EventHandler(this.btn_DeleteAllCrews_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 468);
            this.Controls.Add(this.btn_DeleteAllCrews);
            this.Controls.Add(this.btn_CreateCar);
            this.Controls.Add(this.btn_CreateCrew);
            this.Controls.Add(this.btn_ChooseRnd);
            this.Controls.Add(this.lb_Calendar);
            this.Name = "StartWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Calendar;
        private System.Windows.Forms.Button btn_ChooseRnd;
        private System.Windows.Forms.Button btn_CreateCrew;
        private System.Windows.Forms.OpenFileDialog FileLocater;
        private System.Windows.Forms.FolderBrowserDialog FolderLocater;
        private System.Windows.Forms.Button btn_CreateCar;
        private System.Windows.Forms.Button btn_DeleteAllCrews;
    }
}