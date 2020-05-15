using EF_CONFIG.Data;
using EF_CONFIG.Models;
using MachineTracking.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineTracking
{
    public partial class KnifeCaptureForm : Form
    {
        DataContext DataContext = new DataContext();

        public KnifeCaptureForm()
        {
            InitializeComponent();

            DB_Init.SetupDb(DataContext);
        }

        void KnifeCaptureInit()
        {
            try
            {
                var buildings = DataContext.Building
                    .Include("KC_Devices")
                    .Include("AutoCutMachines")
                    .ToList();

                DS_BUILDING.DataSource = buildings;
            }
            catch (Exception ex)
            { }
        }

        private void BuildingSelectIndexChanged()
        {
            try
            {
                var Bd = cbxBuilding.SelectedItem as Building;
                DS_KC_DEVICE.DataSource = Bd.KC_Devices;
            }
            catch { }
        }

        private void cbxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildingSelectIndexChanged();
        }


        private void KC_DeviceSelectIndexChanged()
        {
            try
            {
                DeviceContainer.Controls.Clear();
                var device = cbxDevice.SelectedItem as KC_Device;
                KnifeCpatureDevice NewDevice = new KnifeCpatureDevice(device);
                DeviceContainer.Controls.Add(NewDevice);
                NewDevice.Dock = DockStyle.Fill;
            }
            catch { }
        }
        private void cbxDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            KC_DeviceSelectIndexChanged();
        }

        private void KnifeCaptureForm_Load(object sender, EventArgs e)
        {
            KnifeCaptureInit();
        }
    }
}
