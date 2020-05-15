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
using System.IO;
using EF_CONFIG.Extends;

namespace MachineTracking.Views
{
    public partial class KnifeCpatureDevice : UserControl
    {
        private DataContext DataContext;
        private KC_ImplementBase KC_ImplementBase;
        private KC_Device KC_Device;
        private Timer UpdateTimer = new Timer { Enabled = true, Interval = 5000, };

        private ContextMenu Menu;

        public KnifeCpatureDevice()
        {
            InitializeComponent();
        }

        public KnifeCpatureDevice(KC_Device KC_Device)
        {
            InitializeComponent();
            UpdateTimer.Tick += UpdateTimer_Tick;
            Menu = new ContextMenu(new MenuItem[] { new MenuItem("Export to excel", ExportToExcel_Callback, Shortcut.CtrlE) });
            this.ContextMenu = Menu;

            DataContext = new DataContext();
            this.KC_Device = KC_Device;
            KC_ImplementBase = new KC_ImplementBase(DataContext);

            UpdateDeviceScreen();
        }

        private void ExportToExcel_Callback(object sender, EventArgs e)
        {
        }

        void ExportData()
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Path = @"\\svproxy\Department\CP\CP Member\Thuong";
            string FilePath = string.Empty;
            try
            {
                if (ExportCurrentWeek.Checked)
                {
                    if (KC_Device != null)
                    {
                        FilePath = KnifeCaptureExport.ExportToExcel_KC_Device(KC_Device, Path, DateTime.Now);
                        if (FilePath != null)
                        {
                            try
                            {
                                System.Diagnostics.Process.Start(FilePath);
                            }
                            catch { }
                        }
                    }
                }

                else
                {
                    FilePath = KnifeCaptureExport.ExportToExcel_KC_Device(KC_Device, Path, dateTimePicker1.Value);
                    if (FilePath != null)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(FilePath);
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        private void UpdateDeviceScreen()
        {
            UpdateTimer.Stop();

            DeviceName.Text = KC_Device.DeviceName;

            // get all post file on date
            var last_record = KC_ImplementBase.Get_KC_LastPostRecord(KC_Device);

            if (last_record == null) return;

            var machines = KC_ImplementBase.Get_KC_DisMachines(last_record);

            if (machines == null)
                return;

            int ControlCounter = MachineContainer.Controls.Count;
            // display the data to view
            for (int i = 0; i < machines.Count; i++)
            {
                var currentControl = new KC_MachineViewer(machines[i]);
                if (ControlCounter > 0)
                {
                    if (MachineContainer.Controls.Count == machines.Count)
                    {
                        var current = MachineContainer.Controls[i] as KC_MachineViewer;
                        current.RefreshData(machines[i]);
                        continue;
                    }
                    else
                    {
                        MachineContainer.Controls.Clear();
                    }
                }

                MachineContainer.Controls.Add(currentControl);
            }

            UpdateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimer.Stop();
            UpdateDeviceScreen();
            UpdateTimer.Start();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportData();
        }
    }
}
