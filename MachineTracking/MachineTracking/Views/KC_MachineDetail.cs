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

namespace MachineTracking.Views
{
    public partial class KC_MachineDetail : UserControl
    {
        public KC_MachineDetail()
        {
            InitializeComponent();
        }

        private DataContext DataContext;
        private AutoCutMachine Machine;
        public KC_MachineDetail(AutoCutMachine Machine)
        {
            InitializeComponent();
            DataContext = new DataContext();
            this.Machine = Machine;

            IntializeMachinesTrackingData();
        }

        private void IntializeMachinesTrackingData()
        {
            try
            {
               var data = DataContext.KnifeCaptureTracking.Where(i => i.MachineId == Machine.Id)
                    .OrderByDescending(i => i.Id)
                    .ToList();

                DS_TRACKING_DATA.DataSource = data;
            }
            catch (Exception ex) { }
        }
    }
}
