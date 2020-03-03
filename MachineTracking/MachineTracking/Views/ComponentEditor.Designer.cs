namespace MachineTracking.Views
{
    partial class ComponentEditor
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.NewComponentControl = new MachineTracking.Views.ComponentProperties();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewComponent = new System.Windows.Forms.Button();
            this.Tab2 = new System.Windows.Forms.TabPage();
            this.EditComponentPanel = new System.Windows.Forms.Panel();
            this.EditComponentControl = new MachineTracking.Views.ComponentProperties();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteComponent = new System.Windows.Forms.Button();
            this.btnUpdateComponent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DS_MachineComponent = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DS_Component = new System.Windows.Forms.BindingSource(this.components);
            this.DS_ComponentStock = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl.SuspendLayout();
            this.Tab1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Tab2.SuspendLayout();
            this.EditComponentPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MachineComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Component)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ComponentStock)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Tab1);
            this.TabControl.Controls.Add(this.Tab2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(4, 4);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(828, 376);
            this.TabControl.TabIndex = 18;
            // 
            // Tab1
            // 
            this.Tab1.Controls.Add(this.NewComponentControl);
            this.Tab1.Controls.Add(this.panel2);
            this.Tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tab1.Location = new System.Drawing.Point(4, 22);
            this.Tab1.Margin = new System.Windows.Forms.Padding(2);
            this.Tab1.Name = "Tab1";
            this.Tab1.Padding = new System.Windows.Forms.Padding(4);
            this.Tab1.Size = new System.Drawing.Size(820, 350);
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "ADD NEW COMPONENT";
            this.Tab1.UseVisualStyleBackColor = true;
            this.Tab1.Enter += new System.EventHandler(this.Tab1_Enter);
            // 
            // NewComponentControl
            // 
            this.NewComponentControl.AutoSize = true;
            this.NewComponentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewComponentControl.Location = new System.Drawing.Point(4, 4);
            this.NewComponentControl.MaximumSize = new System.Drawing.Size(809, 312);
            this.NewComponentControl.Name = "NewComponentControl";
            this.NewComponentControl.Padding = new System.Windows.Forms.Padding(5);
            this.NewComponentControl.Size = new System.Drawing.Size(809, 305);
            this.NewComponentControl.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNewComponent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 37);
            this.panel2.TabIndex = 0;
            // 
            // btnNewComponent
            // 
            this.btnNewComponent.Location = new System.Drawing.Point(353, 1);
            this.btnNewComponent.Name = "btnNewComponent";
            this.btnNewComponent.Size = new System.Drawing.Size(119, 33);
            this.btnNewComponent.TabIndex = 2;
            this.btnNewComponent.Text = "ADD";
            this.btnNewComponent.UseVisualStyleBackColor = true;
            this.btnNewComponent.Click += new System.EventHandler(this.btnNewComponent_Click);
            // 
            // Tab2
            // 
            this.Tab2.Controls.Add(this.EditComponentPanel);
            this.Tab2.Controls.Add(this.panel1);
            this.Tab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tab2.Location = new System.Drawing.Point(4, 22);
            this.Tab2.Margin = new System.Windows.Forms.Padding(2);
            this.Tab2.Name = "Tab2";
            this.Tab2.Padding = new System.Windows.Forms.Padding(4);
            this.Tab2.Size = new System.Drawing.Size(820, 350);
            this.Tab2.TabIndex = 1;
            this.Tab2.Text = "EDIT COMPONENT";
            this.Tab2.UseVisualStyleBackColor = true;
            // 
            // EditComponentPanel
            // 
            this.EditComponentPanel.Controls.Add(this.EditComponentControl);
            this.EditComponentPanel.Controls.Add(this.panel3);
            this.EditComponentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditComponentPanel.Location = new System.Drawing.Point(148, 4);
            this.EditComponentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.EditComponentPanel.Name = "EditComponentPanel";
            this.EditComponentPanel.Padding = new System.Windows.Forms.Padding(2);
            this.EditComponentPanel.Size = new System.Drawing.Size(668, 342);
            this.EditComponentPanel.TabIndex = 22;
            // 
            // EditComponentControl
            // 
            this.EditComponentControl.AutoSize = true;
            this.EditComponentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditComponentControl.Location = new System.Drawing.Point(2, 2);
            this.EditComponentControl.MaximumSize = new System.Drawing.Size(809, 312);
            this.EditComponentControl.Name = "EditComponentControl";
            this.EditComponentControl.Padding = new System.Windows.Forms.Padding(5);
            this.EditComponentControl.Size = new System.Drawing.Size(664, 295);
            this.EditComponentControl.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeleteComponent);
            this.panel3.Controls.Add(this.btnUpdateComponent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 43);
            this.panel3.TabIndex = 0;
            // 
            // btnDeleteComponent
            // 
            this.btnDeleteComponent.Location = new System.Drawing.Point(251, 4);
            this.btnDeleteComponent.Name = "btnDeleteComponent";
            this.btnDeleteComponent.Size = new System.Drawing.Size(107, 33);
            this.btnDeleteComponent.TabIndex = 2;
            this.btnDeleteComponent.Text = "DELETE";
            this.btnDeleteComponent.UseVisualStyleBackColor = true;
            this.btnDeleteComponent.Click += new System.EventHandler(this.btnDeleteComponent_Click);
            // 
            // btnUpdateComponent
            // 
            this.btnUpdateComponent.Location = new System.Drawing.Point(117, 4);
            this.btnUpdateComponent.Name = "btnUpdateComponent";
            this.btnUpdateComponent.Size = new System.Drawing.Size(119, 33);
            this.btnUpdateComponent.TabIndex = 1;
            this.btnUpdateComponent.Text = "UPDATE";
            this.btnUpdateComponent.UseVisualStyleBackColor = true;
            this.btnUpdateComponent.Click += new System.EventHandler(this.btnUpdateComponent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(144, 342);
            this.panel1.TabIndex = 21;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.DS_MachineComponent;
            this.listBox1.DisplayMember = "ComponentCode";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(2, 60);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 280);
            this.listBox1.TabIndex = 20;
            this.listBox1.ValueMember = "ComponentCode";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DS_MachineComponent
            // 
            this.DS_MachineComponent.DataSource = typeof(EF_CONFIG.Models.MachineComponent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(2, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(2, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search for Component";
            // 
            // DS_Component
            // 
            this.DS_Component.DataSource = typeof(EF_CONFIG.Models.MachineComponent);
            // 
            // DS_ComponentStock
            // 
            this.DS_ComponentStock.DataSource = typeof(EF_CONFIG.Models.ComponentStock);
            // 
            // ComponentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ComponentEditor";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(836, 384);
            this.TabControl.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            this.Tab1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Tab2.ResumeLayout(false);
            this.EditComponentPanel.ResumeLayout(false);
            this.EditComponentPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MachineComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Component)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ComponentStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DS_Component;
        private System.Windows.Forms.BindingSource DS_ComponentStock;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.TabPage Tab2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel EditComponentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource DS_MachineComponent;
        private System.Windows.Forms.Panel panel2;
        private ComponentProperties NewComponentControl;
        private System.Windows.Forms.Button btnNewComponent;
        private ComponentProperties EditComponentControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDeleteComponent;
        private System.Windows.Forms.Button btnUpdateComponent;
        private System.Windows.Forms.Label label1;
    }
}