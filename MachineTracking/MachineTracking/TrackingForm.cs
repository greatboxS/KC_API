using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_CONFIG.Data;
using EF_CONFIG.Models;
using MachineTracking.Views;
using Newtonsoft.Json;

namespace MachineTracking
{
    public partial class TrackingForm : Form
    {
        DataContext DataContext = new DataContext();
        public TrackingForm()
        {
            InitializeComponent();

            DB_Init.SetupDb(DataContext);

            InitializeTreeView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Views.ComponentEditor componentEditor = new Views.ComponentEditor();
            componentEditor.Show();
        }

        private void TrackingForm_Load(object sender, EventArgs e)
        {
            KnifeCaptureInit();
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

        void InitializeTreeView()
        {
            try
            {
                BuildingTree.NodeMouseClick += BuildingTree_NodeMouseClick;

                var buildings = DataContext.Building
                    .Include("AutoCutMachines")
                    .ToList();
                foreach (var building in buildings)
                {
                    BuildingTree.Nodes.Add(building.BuildingName, building.BuildingName);
                    foreach (var machine in building.AutoCutMachines)
                    {
                        BuildingTree.Nodes[building.BuildingName].Nodes.Add(machine.MachineName, machine.MachineName);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void BuildingTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string nodeName = e.Node.Name;
        }

        private void Tab4_Enter(object sender, EventArgs e)
        {

        }

        private void BuildingSelectIndexChanged()
        {
            try
            {
                var Bd = cbxBuilding.SelectedItem as Building;
                DS_KC_DEVICE.DataSource = Bd.KC_Devices;
                DS_MACHINE.DataSource = Bd.AutoCutMachines;
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
    }
}
