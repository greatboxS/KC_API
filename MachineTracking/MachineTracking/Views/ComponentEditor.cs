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
using MachineTracking.RuntimeModels;

namespace MachineTracking.Views
{
    public partial class ComponentEditor : UserControl
    {
        private DataContext DataContext;
        private Image ComponentImage;
        private ContextMenu ImageMenuContext;
        public ComponentEditor()
        {
            InitializeComponent();
        }

        private void Tab1_Enter(object sender, EventArgs e)
        {
            //NewComponentControl.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string code = ((TextBox)sender).Text;
            try
            {
                using (DataContext = new DataContext(StatisModels.ProjectProps.FakeServer))
                {
                    var searchList = DataContext.MachineComponent
                        .Where(i => i.ComponentCode.Contains(code));

                    if (searchList.Count() > 0)
                    {
                        DS_MachineComponent.DataSource = searchList.ToList();
                    }
                }
            }
            catch(Exception ex)
            {
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedComponent = (sender as ListBox).SelectedItem as MachineComponent;

                using (DataContext = new DataContext(StatisModels.ProjectProps.FakeServer))
                {
                    var component = DataContext.MachineComponent
                        //.Include("ComponentImages")
                        //.Include("ComponentStocks")
                        .Where(i => i.Id == selectedComponent.Id)
                        .First();

                    EditComponentControl.SetComponentProperties(component.Id);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnNewComponent_Click(object sender, EventArgs e)
        {
            NewComponentControl.AddNewComponent();
        }

        private void btnUpdateComponent_Click(object sender, EventArgs e)
        {
            EditComponentControl.UpdateComponent();
        }

        private void btnDeleteComponent_Click(object sender, EventArgs e)
        {
            EditComponentControl.DeleteComponent();
        }
    }
}
