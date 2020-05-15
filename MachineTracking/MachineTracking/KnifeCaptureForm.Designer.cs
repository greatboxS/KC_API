namespace MachineTracking
{
    partial class KnifeCaptureForm
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
            this.components = new System.ComponentModel.Container();
            this.DeviceContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxBuilding = new System.Windows.Forms.ComboBox();
            this.cbxDevice = new System.Windows.Forms.ComboBox();
            this.DS_BUILDING = new System.Windows.Forms.BindingSource(this.components);
            this.DS_KC_DEVICE = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_BUILDING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_KC_DEVICE)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceContainer
            // 
            this.DeviceContainer.BackColor = System.Drawing.Color.White;
            this.DeviceContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeviceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceContainer.Location = new System.Drawing.Point(146, 0);
            this.DeviceContainer.Name = "DeviceContainer";
            this.DeviceContainer.Padding = new System.Windows.Forms.Padding(5);
            this.DeviceContainer.Size = new System.Drawing.Size(654, 450);
            this.DeviceContainer.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cbxBuilding);
            this.panel3.Controls.Add(this.cbxDevice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 450);
            this.panel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buildings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Knife Capture devices:";
            // 
            // cbxBuilding
            // 
            this.cbxBuilding.DataSource = this.DS_BUILDING;
            this.cbxBuilding.DisplayMember = "BuildingName";
            this.cbxBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuilding.FormattingEnabled = true;
            this.cbxBuilding.Location = new System.Drawing.Point(12, 44);
            this.cbxBuilding.Name = "cbxBuilding";
            this.cbxBuilding.Size = new System.Drawing.Size(125, 21);
            this.cbxBuilding.TabIndex = 0;
            this.cbxBuilding.ValueMember = "BuildingName";
            this.cbxBuilding.SelectedIndexChanged += new System.EventHandler(this.cbxBuilding_SelectedIndexChanged);
            // 
            // cbxDevice
            // 
            this.cbxDevice.DataSource = this.DS_KC_DEVICE;
            this.cbxDevice.DisplayMember = "DeviceName";
            this.cbxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDevice.FormattingEnabled = true;
            this.cbxDevice.Location = new System.Drawing.Point(12, 84);
            this.cbxDevice.Name = "cbxDevice";
            this.cbxDevice.Size = new System.Drawing.Size(125, 21);
            this.cbxDevice.TabIndex = 10;
            this.cbxDevice.SelectedIndexChanged += new System.EventHandler(this.cbxDevice_SelectedIndexChanged);
            // 
            // DS_BUILDING
            // 
            this.DS_BUILDING.DataSource = typeof(EF_CONFIG.Models.Building);
            // 
            // DS_KC_DEVICE
            // 
            this.DS_KC_DEVICE.DataSource = typeof(EF_CONFIG.Models.KC_Device);
            // 
            // KnifeCaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeviceContainer);
            this.Controls.Add(this.panel3);
            this.Name = "KnifeCaptureForm";
            this.Text = "KnifeCaptureForm";
            this.Load += new System.EventHandler(this.KnifeCaptureForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_BUILDING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_KC_DEVICE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DeviceContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxBuilding;
        private System.Windows.Forms.ComboBox cbxDevice;
        private System.Windows.Forms.BindingSource DS_BUILDING;
        private System.Windows.Forms.BindingSource DS_KC_DEVICE;
    }
}