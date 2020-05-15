namespace MachineTracking.Views
{
    partial class KnifeCpatureDevice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MachineContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeviceName = new System.Windows.Forms.Label();
            this.ExportCurrentWeek = new System.Windows.Forms.RadioButton();
            this.CustomExport = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MachineContainer
            // 
            this.MachineContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineContainer.Location = new System.Drawing.Point(0, 56);
            this.MachineContainer.Name = "MachineContainer";
            this.MachineContainer.Size = new System.Drawing.Size(633, 411);
            this.MachineContainer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.CustomExport);
            this.panel1.Controls.Add(this.ExportCurrentWeek);
            this.panel1.Controls.Add(this.DeviceName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 56);
            this.panel1.TabIndex = 2;
            // 
            // DeviceName
            // 
            this.DeviceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceName.Location = new System.Drawing.Point(0, 0);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(633, 30);
            this.DeviceName.TabIndex = 1;
            this.DeviceName.Text = "DEIVCE NAME";
            this.DeviceName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExportCurrentWeek
            // 
            this.ExportCurrentWeek.AutoSize = true;
            this.ExportCurrentWeek.Checked = true;
            this.ExportCurrentWeek.Location = new System.Drawing.Point(34, 33);
            this.ExportCurrentWeek.Name = "ExportCurrentWeek";
            this.ExportCurrentWeek.Size = new System.Drawing.Size(120, 17);
            this.ExportCurrentWeek.TabIndex = 2;
            this.ExportCurrentWeek.TabStop = true;
            this.ExportCurrentWeek.Text = "Export current week";
            this.ExportCurrentWeek.UseVisualStyleBackColor = true;
            // 
            // CustomExport
            // 
            this.CustomExport.AutoSize = true;
            this.CustomExport.Location = new System.Drawing.Point(182, 33);
            this.CustomExport.Name = "CustomExport";
            this.CustomExport.Size = new System.Drawing.Size(120, 17);
            this.CustomExport.TabIndex = 3;
            this.CustomExport.Text = "Select date of week";
            this.CustomExport.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(472, 27);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // KnifeCpatureDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.MachineContainer);
            this.Controls.Add(this.panel1);
            this.Name = "KnifeCpatureDevice";
            this.Size = new System.Drawing.Size(633, 467);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel MachineContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton CustomExport;
        private System.Windows.Forms.RadioButton ExportCurrentWeek;
        private System.Windows.Forms.Label DeviceName;
    }
}
