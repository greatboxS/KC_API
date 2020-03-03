using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_CONFIG.Data;
using EF_CONFIG.Models;
using EF_CONFIG.Base;
using EF_CONFIG.DataTransform;

namespace MachineTracking.Views
{
    public partial class MachineDetailForm : Form
    {
        private DataContext DataContext;
        private KC_ImplementBase KC_ImplementBase;
        private AutoCutMachine Machine;
        private DateTime SelectedDate;
        private KC_DisMachine KC_DisMachine;
        public MachineDetailForm()
        {
            InitializeComponent();
        }

        public MachineDetailForm(KC_DisMachine KC_DisMachine, AutoCutMachine machine)
        {
            InitializeComponent();
            DataContext = new DataContext();
            KC_ImplementBase = new KC_ImplementBase(DataContext);
            this.KC_DisMachine = KC_DisMachine;
            Machine = machine;
            this.Text = $"MACHINE: {machine.MachineName}";
            DS_AutoCutMachine.DataSource = Machine;
        }

        private void Get_SigleDateDetail()
        {
            var knife_captures = KC_ImplementBase.Get_KnifeCaptureTrackings(Machine, SelectedDate);
            AppendData(knife_captures);
        }

        private void AppendData(List<KnifeCaptureTracking> knife_captures)
        {
            int Total = 0;

            try
            {
                DataTable DetailTable = new DataTable();
                DetailTable.Columns.Add("Total captured");
                DetailTable.Columns.Add("Time");
                DetailTable.Columns.Add("Knife Type");
                DetailTable.Columns.Add("Position");
                DetailTable.Columns.Add("Knife Name");
                DetailTable.Columns.Add("Current");


                foreach (var item in knife_captures)
                {
                    Total++;
                    
                    var knife = ComponentBase.Get_Knife(item.LocalKnifeId);
                    string knife_name = knife != null ? knife.ComponentCode : string.Empty;

                    DetailTable.Rows.Add(new object[] { Total, item.UpdateTime.ToString("ddd, dd/MM/yy, hh:ss tt"), item.KType, item.KPosition, knife_name, item.LocalValue });
                }

                txtOldLeft.Text = KC_DisMachine.OldLeft.ToString();
                txtOldRight.Text = KC_DisMachine.OldRight.ToString();
                txtNewLeft.Text = KC_DisMachine.NewLeft.ToString();
                txtNewRight.Text = KC_DisMachine.NewRight.ToString();
                lbTotalOld.Text= (KC_DisMachine.OldLeft + KC_DisMachine.OldRight).ToString();
                lbTotalNew.Text = (KC_DisMachine.NewLeft + KC_DisMachine.NewRight).ToString();

                DetailData.DataSource = DetailTable;
                DetailData.Columns[0].Width = 50;
                DetailData.Columns[1].Width = 130;
                DetailData.Columns[2].Width = 70;
                DetailData.Columns[3].Width = 70;
                DetailData.Columns[4].Width = 50;
                DetailData.Columns[5].Width = 50;

            }
            catch { }
        }

        private void Get_WeekDetail()
        {
            var knife_captures = KC_ImplementBase.Get_KnifeCaptureTrackingsOnWeek(Machine);
            AppendData(knife_captures);
        }

        public void RefreshDetail(KC_DisMachine KC_DisMachine)
        {
            this.KC_DisMachine = KC_DisMachine;
            SelectedDate = DatePicker.Value;
            var last_post = KC_ImplementBase.Get_LastPostRecord(Machine);
            if (last_post != null)
                lbLastUpdate.Text = last_post.UpdateTime.ToString("ddd, dd/MM/yy, hh:ss tt");

            if (cbWeek.Checked)
            {
                Get_WeekDetail();
            }
            else
            {
                Get_SigleDateDetail();
            }
        }

        private void btnGetDetail_Click(object sender, EventArgs e)
        {
            RefreshDetail(this.KC_DisMachine);
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            var Current = sender as ComboBox;
            Current.Items.Clear();

            for (int i = 0; i < 7; i++)
            {
                Current.Items.Add(((DayOfWeek)i).ToString());
            }
        }

        private void btnSaveChanged_Click(object sender, EventArgs e)
        {
            if (KC_ImplementBase.Update_AutoCutMachine(Machine))
                MessageBox.Show("Success");
            else
                MessageBox.Show("Error");
        }

        private void DetailData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                DataGridViewRow CurrentRow = DetailData.Rows[e.RowIndex];
                string knife_type = CurrentRow.Cells[2].Value.ToString().ToLower();
                string knife_pos = CurrentRow.Cells[3].Value.ToString().ToLower();

                if (knife_type == "new knife")
                {
                    CurrentRow.DefaultCellStyle.BackColor = Color.LightBlue;
                }

                if (knife_type == "old knife")
                {
                    CurrentRow.DefaultCellStyle.BackColor = Color.Silver;
                }

                if (knife_pos.Contains("left"))
                {
                    CurrentRow.Cells[3].Style.BackColor = Color.LightGreen;
                }

                if (knife_pos.Contains("right"))
                {
                    CurrentRow.Cells[3].Style.BackColor = Color.LightYellow;
                }

            }
            catch { }
        }
    }
}
