namespace MachineTracking
{
    partial class TrackingForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BuildingTree = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab2 = new System.Windows.Forms.TabPage();
            this.Tab3 = new System.Windows.Forms.TabPage();
            this.Tab4 = new System.Windows.Forms.TabPage();
            this.DeviceContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxBuilding = new System.Windows.Forms.ComboBox();
            this.DS_BUILDING = new System.Windows.Forms.BindingSource(this.components);
            this.cbxDevice = new System.Windows.Forms.ComboBox();
            this.DS_KC_DEVICE = new System.Windows.Forms.BindingSource(this.components);
            this.DS_MACHINE = new System.Windows.Forms.BindingSource(this.components);
            this.componentEditor1 = new MachineTracking.Views.ComponentEditor();
            this.tabControl1.SuspendLayout();
            this.Tab1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Tab2.SuspendLayout();
            this.Tab4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_BUILDING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_KC_DEVICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MACHINE)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab1);
            this.tabControl1.Controls.Add(this.Tab2);
            this.tabControl1.Controls.Add(this.Tab3);
            this.tabControl1.Controls.Add(this.Tab4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(119, 30);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab1
            // 
            this.Tab1.Controls.Add(this.panel1);
            this.Tab1.Location = new System.Drawing.Point(4, 34);
            this.Tab1.Name = "Tab1";
            this.Tab1.Padding = new System.Windows.Forms.Padding(3);
            this.Tab1.Size = new System.Drawing.Size(943, 430);
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "MACHINE TRACKING";
            this.Tab1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.BuildingTree);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(157, 424);
            this.panel1.TabIndex = 0;
            // 
            // BuildingTree
            // 
            this.BuildingTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuildingTree.Location = new System.Drawing.Point(5, 52);
            this.BuildingTree.Name = "BuildingTree";
            this.BuildingTree.Size = new System.Drawing.Size(147, 367);
            this.BuildingTree.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 47);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select machine";
            // 
            // Tab2
            // 
            this.Tab2.Controls.Add(this.componentEditor1);
            this.Tab2.Location = new System.Drawing.Point(4, 34);
            this.Tab2.Name = "Tab2";
            this.Tab2.Padding = new System.Windows.Forms.Padding(3);
            this.Tab2.Size = new System.Drawing.Size(943, 430);
            this.Tab2.TabIndex = 1;
            this.Tab2.Text = "COMPONENT TRACKING";
            this.Tab2.UseVisualStyleBackColor = true;
            // 
            // Tab3
            // 
            this.Tab3.Location = new System.Drawing.Point(4, 34);
            this.Tab3.Name = "Tab3";
            this.Tab3.Size = new System.Drawing.Size(943, 430);
            this.Tab3.TabIndex = 2;
            this.Tab3.Text = "STATISTIC";
            this.Tab3.UseVisualStyleBackColor = true;
            // 
            // Tab4
            // 
            this.Tab4.Controls.Add(this.DeviceContainer);
            this.Tab4.Controls.Add(this.panel3);
            this.Tab4.Location = new System.Drawing.Point(4, 34);
            this.Tab4.Name = "Tab4";
            this.Tab4.Size = new System.Drawing.Size(943, 430);
            this.Tab4.TabIndex = 3;
            this.Tab4.Text = "KNIFE_CAPTURE";
            this.Tab4.UseVisualStyleBackColor = true;
            this.Tab4.Enter += new System.EventHandler(this.Tab4_Enter);
            // 
            // DeviceContainer
            // 
            this.DeviceContainer.BackColor = System.Drawing.Color.White;
            this.DeviceContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeviceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceContainer.Location = new System.Drawing.Point(145, 0);
            this.DeviceContainer.Name = "DeviceContainer";
            this.DeviceContainer.Padding = new System.Windows.Forms.Padding(5);
            this.DeviceContainer.Size = new System.Drawing.Size(798, 430);
            this.DeviceContainer.TabIndex = 13;
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
            this.panel3.Size = new System.Drawing.Size(145, 430);
            this.panel3.TabIndex = 12;
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
            this.cbxBuilding.SelectedIndexChanged += new System.EventHandler(this.cbxBuilding_SelectedIndexChanged);
            // 
            // DS_BUILDING
            // 
            this.DS_BUILDING.DataSource = typeof(EF_CONFIG.Models.Building);
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
            // DS_KC_DEVICE
            // 
            this.DS_KC_DEVICE.DataSource = typeof(EF_CONFIG.Models.KC_Device);
            // 
            // DS_MACHINE
            // 
            this.DS_MACHINE.DataSource = typeof(EF_CONFIG.Models.AutoCutMachine);
            // 
            // componentEditor1
            // 
            this.componentEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentEditor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.componentEditor1.Location = new System.Drawing.Point(3, 3);
            this.componentEditor1.Name = "componentEditor1";
            this.componentEditor1.Padding = new System.Windows.Forms.Padding(4);
            this.componentEditor1.Size = new System.Drawing.Size(937, 424);
            this.componentEditor1.TabIndex = 0;
            // 
            // TrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 478);
            this.Controls.Add(this.tabControl1);
            this.Name = "TrackingForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Load += new System.EventHandler(this.TrackingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Tab2.ResumeLayout(false);
            this.Tab4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_BUILDING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_KC_DEVICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MACHINE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.TabPage Tab2;
        private System.Windows.Forms.TabPage Tab3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView BuildingTree;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Tab4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxBuilding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxDevice;
        private System.Windows.Forms.Panel DeviceContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource DS_BUILDING;
        private System.Windows.Forms.BindingSource DS_KC_DEVICE;
        private System.Windows.Forms.BindingSource DS_MACHINE;
        private Views.ComponentEditor componentEditor1;
    }
}

