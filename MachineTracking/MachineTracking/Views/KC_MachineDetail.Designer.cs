namespace MachineTracking.Views
{
    partial class KC_MachineDetail
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.machineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kCDeviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_TRACKING_DATA = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_TRACKING_DATA)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MACHINE NAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(147, 399);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineIdDataGridViewTextBoxColumn,
            this.kCDeviceIdDataGridViewTextBoxColumn,
            this.localValueDataGridViewTextBoxColumn,
            this.timeStrDataGridViewTextBoxColumn,
            this.kTypeDataGridViewTextBoxColumn,
            this.kPositionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.DS_TRACKING_DATA;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // machineIdDataGridViewTextBoxColumn
            // 
            this.machineIdDataGridViewTextBoxColumn.DataPropertyName = "MachineId";
            this.machineIdDataGridViewTextBoxColumn.HeaderText = "MachineId";
            this.machineIdDataGridViewTextBoxColumn.Name = "machineIdDataGridViewTextBoxColumn";
            // 
            // kCDeviceIdDataGridViewTextBoxColumn
            // 
            this.kCDeviceIdDataGridViewTextBoxColumn.DataPropertyName = "KC_DeviceId";
            this.kCDeviceIdDataGridViewTextBoxColumn.HeaderText = "KC_DeviceId";
            this.kCDeviceIdDataGridViewTextBoxColumn.Name = "kCDeviceIdDataGridViewTextBoxColumn";
            // 
            // localValueDataGridViewTextBoxColumn
            // 
            this.localValueDataGridViewTextBoxColumn.DataPropertyName = "LocalValue";
            this.localValueDataGridViewTextBoxColumn.HeaderText = "LocalValue";
            this.localValueDataGridViewTextBoxColumn.Name = "localValueDataGridViewTextBoxColumn";
            // 
            // timeStrDataGridViewTextBoxColumn
            // 
            this.timeStrDataGridViewTextBoxColumn.DataPropertyName = "TimeStr";
            this.timeStrDataGridViewTextBoxColumn.HeaderText = "TimeStr";
            this.timeStrDataGridViewTextBoxColumn.Name = "timeStrDataGridViewTextBoxColumn";
            // 
            // kTypeDataGridViewTextBoxColumn
            // 
            this.kTypeDataGridViewTextBoxColumn.DataPropertyName = "KType";
            this.kTypeDataGridViewTextBoxColumn.HeaderText = "KType";
            this.kTypeDataGridViewTextBoxColumn.Name = "kTypeDataGridViewTextBoxColumn";
            this.kTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kPositionDataGridViewTextBoxColumn
            // 
            this.kPositionDataGridViewTextBoxColumn.DataPropertyName = "KPosition";
            this.kPositionDataGridViewTextBoxColumn.HeaderText = "KPosition";
            this.kPositionDataGridViewTextBoxColumn.Name = "kPositionDataGridViewTextBoxColumn";
            this.kPositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DS_TRACKING_DATA
            // 
            this.DS_TRACKING_DATA.DataSource = typeof(EF_CONFIG.Models.KnifeCaptureTracking);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(147, 33);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(570, 399);
            this.panel2.TabIndex = 2;
            // 
            // KC_MachineDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "KC_MachineDetail";
            this.Size = new System.Drawing.Size(717, 432);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_TRACKING_DATA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kCDeviceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource DS_TRACKING_DATA;
        private System.Windows.Forms.Panel panel2;
    }
}
