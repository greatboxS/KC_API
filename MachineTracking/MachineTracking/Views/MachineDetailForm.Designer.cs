namespace MachineTracking.Views
{
    partial class MachineDetailForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DS_AutoCutMachine = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLastUpdate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalNew = new System.Windows.Forms.Label();
            this.lbTotalOld = new System.Windows.Forms.Label();
            this.txtNewRight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOldRight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewLeft = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOldLeft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnGetDetail = new System.Windows.Forms.Button();
            this.cbWeek = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveChanged = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DetailData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DS_AutoCutMachine)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailData)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_AutoCutMachine, "ResetCounterDate", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // DS_AutoCutMachine
            // 
            this.DS_AutoCutMachine.DataSource = typeof(EF_CONFIG.Models.AutoCutMachine);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reset Date";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_AutoCutMachine, "TotalCounterDay", true));
            this.textBox1.Location = new System.Drawing.Point(163, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total days";
            // 
            // lbLastUpdate
            // 
            this.lbLastUpdate.AutoSize = true;
            this.lbLastUpdate.Location = new System.Drawing.Point(3, 4);
            this.lbLastUpdate.Name = "lbLastUpdate";
            this.lbLastUpdate.Size = new System.Drawing.Size(88, 13);
            this.lbLastUpdate.TabIndex = 4;
            this.lbLastUpdate.Text = "#last update time";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTotalNew);
            this.panel1.Controls.Add(this.lbTotalOld);
            this.panel1.Controls.Add(this.txtNewRight);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtOldRight);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNewLeft);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOldLeft);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DatePicker);
            this.panel1.Controls.Add(this.btnGetDetail);
            this.panel1.Controls.Add(this.cbWeek);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSaveChanged);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 138);
            this.panel1.TabIndex = 5;
            // 
            // lbTotalNew
            // 
            this.lbTotalNew.AutoSize = true;
            this.lbTotalNew.Location = new System.Drawing.Point(196, 116);
            this.lbTotalNew.Name = "lbTotalNew";
            this.lbTotalNew.Size = new System.Drawing.Size(20, 13);
            this.lbTotalNew.TabIndex = 19;
            this.lbTotalNew.Text = "#1";
            // 
            // lbTotalOld
            // 
            this.lbTotalOld.AutoSize = true;
            this.lbTotalOld.Location = new System.Drawing.Point(196, 89);
            this.lbTotalOld.Name = "lbTotalOld";
            this.lbTotalOld.Size = new System.Drawing.Size(20, 13);
            this.lbTotalOld.TabIndex = 18;
            this.lbTotalOld.Text = "#1";
            // 
            // txtNewRight
            // 
            this.txtNewRight.Location = new System.Drawing.Point(356, 113);
            this.txtNewRight.Name = "txtNewRight";
            this.txtNewRight.Size = new System.Drawing.Size(55, 20);
            this.txtNewRight.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total New";
            // 
            // txtOldRight
            // 
            this.txtOldRight.Location = new System.Drawing.Point(356, 86);
            this.txtOldRight.Name = "txtOldRight";
            this.txtOldRight.Size = new System.Drawing.Size(55, 20);
            this.txtOldRight.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Old";
            // 
            // txtNewLeft
            // 
            this.txtNewLeft.Location = new System.Drawing.Point(75, 113);
            this.txtNewLeft.Name = "txtNewLeft";
            this.txtNewLeft.Size = new System.Drawing.Size(55, 20);
            this.txtNewLeft.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total New";
            // 
            // txtOldLeft
            // 
            this.txtOldLeft.Location = new System.Drawing.Point(75, 86);
            this.txtOldLeft.Name = "txtOldLeft";
            this.txtOldLeft.Size = new System.Drawing.Size(55, 20);
            this.txtOldLeft.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Old";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(82, 53);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(134, 20);
            this.DatePicker.TabIndex = 9;
            // 
            // btnGetDetail
            // 
            this.btnGetDetail.Location = new System.Drawing.Point(339, 50);
            this.btnGetDetail.Name = "btnGetDetail";
            this.btnGetDetail.Size = new System.Drawing.Size(75, 23);
            this.btnGetDetail.TabIndex = 8;
            this.btnGetDetail.Text = "Get detail";
            this.btnGetDetail.UseVisualStyleBackColor = true;
            this.btnGetDetail.Click += new System.EventHandler(this.btnGetDetail_Click);
            // 
            // cbWeek
            // 
            this.cbWeek.AutoSize = true;
            this.cbWeek.Location = new System.Drawing.Point(236, 56);
            this.cbWeek.Name = "cbWeek";
            this.cbWeek.Size = new System.Drawing.Size(75, 17);
            this.cbWeek.TabIndex = 7;
            this.cbWeek.Text = "This week";
            this.cbWeek.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "View Date:";
            // 
            // btnSaveChanged
            // 
            this.btnSaveChanged.Location = new System.Drawing.Point(339, 16);
            this.btnSaveChanged.Name = "btnSaveChanged";
            this.btnSaveChanged.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanged.TabIndex = 4;
            this.btnSaveChanged.Text = "Save";
            this.btnSaveChanged.UseVisualStyleBackColor = true;
            this.btnSaveChanged.Click += new System.EventHandler(this.btnSaveChanged_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbLastUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 21);
            this.panel2.TabIndex = 6;
            // 
            // DetailData
            // 
            this.DetailData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailData.Location = new System.Drawing.Point(5, 143);
            this.DetailData.Name = "DetailData";
            this.DetailData.ReadOnly = true;
            this.DetailData.RowHeadersWidth = 10;
            this.DetailData.Size = new System.Drawing.Size(439, 347);
            this.DetailData.TabIndex = 7;
            this.DetailData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DetailData_RowPrePaint);
            // 
            // MachineDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 516);
            this.Controls.Add(this.DetailData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(465, 2000);
            this.Name = "MachineDetailForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MachineDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.DS_AutoCutMachine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLastUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveChanged;
        private System.Windows.Forms.CheckBox cbWeek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DetailData;
        private System.Windows.Forms.Button btnGetDetail;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label lbTotalNew;
        private System.Windows.Forms.Label lbTotalOld;
        private System.Windows.Forms.TextBox txtNewRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOldRight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNewLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOldLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource DS_AutoCutMachine;
    }
}