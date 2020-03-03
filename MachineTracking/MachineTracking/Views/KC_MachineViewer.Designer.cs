namespace MachineTracking.Views
{
    partial class KC_MachineViewer
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
            this.MachineName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewLeft = new System.Windows.Forms.TextBox();
            this.txtOldLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOldRight = new System.Windows.Forms.TextBox();
            this.txtNewRight = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLastUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalDays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResetDate = new System.Windows.Forms.TextBox();
            this.btnMachineDetail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MachineName
            // 
            this.MachineName.Dock = System.Windows.Forms.DockStyle.Top;
            this.MachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineName.Location = new System.Drawing.Point(3, 3);
            this.MachineName.Name = "MachineName";
            this.MachineName.Size = new System.Drawing.Size(154, 43);
            this.MachineName.TabIndex = 0;
            this.MachineName.Text = "MACHINE NAME";
            this.MachineName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Knife value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNewLeft
            // 
            this.txtNewLeft.Location = new System.Drawing.Point(40, 65);
            this.txtNewLeft.Name = "txtNewLeft";
            this.txtNewLeft.Size = new System.Drawing.Size(40, 20);
            this.txtNewLeft.TabIndex = 2;
            // 
            // txtOldLeft
            // 
            this.txtOldLeft.Location = new System.Drawing.Point(40, 105);
            this.txtOldLeft.Name = "txtOldLeft";
            this.txtOldLeft.Size = new System.Drawing.Size(40, 20);
            this.txtOldLeft.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Left:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "New:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Old:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Right:";
            // 
            // txtOldRight
            // 
            this.txtOldRight.Location = new System.Drawing.Point(100, 105);
            this.txtOldRight.Name = "txtOldRight";
            this.txtOldRight.Size = new System.Drawing.Size(40, 20);
            this.txtOldRight.TabIndex = 8;
            // 
            // txtNewRight
            // 
            this.txtNewRight.Location = new System.Drawing.Point(100, 65);
            this.txtNewRight.Name = "txtNewRight";
            this.txtNewRight.Size = new System.Drawing.Size(40, 20);
            this.txtNewRight.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtOldRight);
            this.panel1.Controls.Add(this.txtNewLeft);
            this.panel1.Controls.Add(this.txtNewRight);
            this.panel1.Controls.Add(this.txtOldLeft);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 132);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMachineDetail);
            this.panel2.Controls.Add(this.txtLastUpdate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTotalDays);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtResetDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 181);
            this.panel2.TabIndex = 11;
            // 
            // txtLastUpdate
            // 
            this.txtLastUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLastUpdate.Location = new System.Drawing.Point(0, 126);
            this.txtLastUpdate.Name = "txtLastUpdate";
            this.txtLastUpdate.Size = new System.Drawing.Size(154, 20);
            this.txtLastUpdate.TabIndex = 12;
            this.txtLastUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 33);
            this.label9.TabIndex = 11;
            this.label9.Text = "Last knife captured time:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtTotalDays
            // 
            this.txtTotalDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTotalDays.Location = new System.Drawing.Point(0, 73);
            this.txtTotalDays.Name = "txtTotalDays";
            this.txtTotalDays.Size = new System.Drawing.Size(154, 20);
            this.txtTotalDays.TabIndex = 8;
            this.txtTotalDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total tracking days:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reset counter date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtResetDate
            // 
            this.txtResetDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtResetDate.Location = new System.Drawing.Point(0, 24);
            this.txtResetDate.Name = "txtResetDate";
            this.txtResetDate.Size = new System.Drawing.Size(154, 20);
            this.txtResetDate.TabIndex = 13;
            this.txtResetDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMachineDetail
            // 
            this.btnMachineDetail.AutoSize = true;
            this.btnMachineDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMachineDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMachineDetail.ForeColor = System.Drawing.Color.Blue;
            this.btnMachineDetail.Location = new System.Drawing.Point(48, 161);
            this.btnMachineDetail.Name = "btnMachineDetail";
            this.btnMachineDetail.Size = new System.Drawing.Size(34, 13);
            this.btnMachineDetail.TabIndex = 14;
            this.btnMachineDetail.Text = "Detail";
            this.btnMachineDetail.Click += new System.EventHandler(this.MachineDetail_Click);
            // 
            // KC_MachineViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MachineName);
            this.MinimumSize = new System.Drawing.Size(162, 364);
            this.Name = "KC_MachineViewer";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(160, 362);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MachineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewLeft;
        private System.Windows.Forms.TextBox txtOldLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOldRight;
        private System.Windows.Forms.TextBox txtNewRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLastUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResetDate;
        private System.Windows.Forms.Label btnMachineDetail;
    }
}
