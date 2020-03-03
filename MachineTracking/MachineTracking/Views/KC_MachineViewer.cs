using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_CONFIG.Data;
using EF_CONFIG.Models;
using EF_CONFIG.Base;

namespace MachineTracking.Views
{
    public partial class KC_MachineViewer : UserControl
    {
        private DataContext DataContext;
        private AutoCutMachine Machine;
        private KC_DisMachine KC_DisMachine;
        MachineDetailForm machineDetailForm;
        KC_ImplementBase KC_ImplementBase;
        public KC_MachineViewer()
        {
            InitializeComponent();
        }

        public KC_MachineViewer(KC_DisMachine DisMachine)
        {
            InitializeComponent();
            RefreshData(DisMachine);
        }

        public void RefreshData(KC_DisMachine DisMachine)
        {
            KC_DisMachine = DisMachine;
            DataContext = new DataContext();
            KC_ImplementBase = new KC_ImplementBase(DataContext);
            Machine = new AutoCutMachine();
            Machine = KC_ImplementBase.Get_AutoCutMachine((int)KC_DisMachine.AutoCutMachineId);

            if (machineDetailForm == null)
                machineDetailForm = new MachineDetailForm(DisMachine, Machine);
            else
                machineDetailForm.RefreshDetail(DisMachine);

            UpdateMachineInfo();
        }
        private void UpdateMachineInfo()
        {
            if (Machine == null)
                return;

            MachineName.Text = Machine.MachineName;
            txtResetDate.Text = Machine.ResetCounterDate;
            txtTotalDays.Text = Machine.TotalCounterDay.ToString();
            txtOldLeft.Text = KC_DisMachine.OldLeft.ToString();
            txtOldRight.Text = KC_DisMachine.OldRight.ToString();
            txtNewLeft.Text = KC_DisMachine.NewLeft.ToString();
            txtNewRight.Text = KC_DisMachine.NewRight.ToString();
            txtLastUpdate.Text = KC_DisMachine.DateTimeStr;
        }

        private void MachineDetail_Click(object sender, EventArgs e)
        {
            if (machineDetailForm.IsDisposed)
                machineDetailForm = new MachineDetailForm(KC_DisMachine, Machine);

            machineDetailForm.Show();
            machineDetailForm.BringToFront();

        }
    }
}
