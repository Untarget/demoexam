namespace WindowsFormsApp
{
    partial class AdministratorMainForm
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
            this.buttonReservaition = new System.Windows.Forms.Button();
            this.buttonApartmentsInfo = new System.Windows.Forms.Button();
            this.buttonCheckEmployeesWork = new System.Windows.Forms.Button();
            this.buttonGetOut = new System.Windows.Forms.Button();
            this.buttonGetIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReservaition
            // 
            this.buttonReservaition.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReservaition.Location = new System.Drawing.Point(0, 0);
            this.buttonReservaition.Name = "buttonReservaition";
            this.buttonReservaition.Size = new System.Drawing.Size(1086, 80);
            this.buttonReservaition.TabIndex = 2;
            this.buttonReservaition.Text = "Бронирование";
            this.buttonReservaition.UseVisualStyleBackColor = true;
            this.buttonReservaition.Click += new System.EventHandler(this.buttonReservaition_Click);
            // 
            // buttonApartmentsInfo
            // 
            this.buttonApartmentsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonApartmentsInfo.Location = new System.Drawing.Point(0, 240);
            this.buttonApartmentsInfo.Name = "buttonApartmentsInfo";
            this.buttonApartmentsInfo.Size = new System.Drawing.Size(1086, 167);
            this.buttonApartmentsInfo.TabIndex = 4;
            this.buttonApartmentsInfo.Text = "Информация о номерах";
            this.buttonApartmentsInfo.UseVisualStyleBackColor = true;
            this.buttonApartmentsInfo.Click += new System.EventHandler(this.buttonApartmentsInfo_Click);
            // 
            // buttonCheckEmployeesWork
            // 
            this.buttonCheckEmployeesWork.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCheckEmployeesWork.Location = new System.Drawing.Point(0, 407);
            this.buttonCheckEmployeesWork.Name = "buttonCheckEmployeesWork";
            this.buttonCheckEmployeesWork.Size = new System.Drawing.Size(1086, 74);
            this.buttonCheckEmployeesWork.TabIndex = 8;
            this.buttonCheckEmployeesWork.Text = "Уборочные работы";
            this.buttonCheckEmployeesWork.UseVisualStyleBackColor = true;
            this.buttonCheckEmployeesWork.Click += new System.EventHandler(this.buttonCheckEmployeesWork_Click);
            // 
            // buttonGetOut
            // 
            this.buttonGetOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGetOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGetOut.Location = new System.Drawing.Point(0, 80);
            this.buttonGetOut.Name = "buttonGetOut";
            this.buttonGetOut.Size = new System.Drawing.Size(1086, 80);
            this.buttonGetOut.TabIndex = 3;
            this.buttonGetOut.Text = "Заселение";
            this.buttonGetOut.UseVisualStyleBackColor = true;
            this.buttonGetOut.Click += new System.EventHandler(this.buttonGetOut_Click);
            // 
            // buttonGetIn
            // 
            this.buttonGetIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGetIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGetIn.Location = new System.Drawing.Point(0, 160);
            this.buttonGetIn.Name = "buttonGetIn";
            this.buttonGetIn.Size = new System.Drawing.Size(1086, 80);
            this.buttonGetIn.TabIndex = 5;
            this.buttonGetIn.Text = "Выселение";
            this.buttonGetIn.UseVisualStyleBackColor = true;
            this.buttonGetIn.Click += new System.EventHandler(this.buttonGetIn_Click);
            // 
            // AdministratorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 481);
            this.Controls.Add(this.buttonApartmentsInfo);
            this.Controls.Add(this.buttonCheckEmployeesWork);
            this.Controls.Add(this.buttonGetIn);
            this.Controls.Add(this.buttonGetOut);
            this.Controls.Add(this.buttonReservaition);
            this.Name = "AdministratorMainForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorMainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonReservaition;
        private System.Windows.Forms.Button buttonApartmentsInfo;
        private System.Windows.Forms.Button buttonCheckEmployeesWork;
        private System.Windows.Forms.Button buttonGetOut;
        private System.Windows.Forms.Button buttonGetIn;
    }
}