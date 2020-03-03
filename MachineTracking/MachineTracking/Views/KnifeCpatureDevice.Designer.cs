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
            this.DeviceName = new System.Windows.Forms.Label();
            this.MachineContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // DeviceName
            // 
            this.DeviceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceName.Location = new System.Drawing.Point(0, 0);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(633, 39);
            this.DeviceName.TabIndex = 0;
            this.DeviceName.Text = "DEIVCE NAME";
            this.DeviceName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MachineContainer
            // 
            this.MachineContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineContainer.Location = new System.Drawing.Point(0, 39);
            this.MachineContainer.Name = "MachineContainer";
            this.MachineContainer.Size = new System.Drawing.Size(633, 428);
            this.MachineContainer.TabIndex = 1;
            // 
            // KnifeCpatureDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.MachineContainer);
            this.Controls.Add(this.DeviceName);
            this.Name = "KnifeCpatureDevice";
            this.Size = new System.Drawing.Size(633, 467);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label DeviceName;
        private System.Windows.Forms.FlowLayoutPanel MachineContainer;
    }
}
