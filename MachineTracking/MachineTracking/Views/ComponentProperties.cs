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
    public partial class ComponentProperties : UserControl
    {
        private DataContext DataContext;
        private ComponentImage CurrentImage = new ComponentImage();
        private ContextMenu ImageMenuContext;
        private MachineComponent CurrentComponent = new MachineComponent();
        private ComponentStock CurrentStock = new ComponentStock();

        public ComponentProperties()
        {
            InitializeComponent();
            DS_Component.DataSource = CurrentComponent;
            DS_ComponentStock.DataSource = CurrentStock;
            DS_ComponentImage.DataSource = CurrentImage;

            ImageMenuContext = new ContextMenu(new MenuItem[] { new MenuItem("Parse Image", ImageParseClickCallback, Shortcut.CtrlV) });
            this.ContextMenu = ImageMenuContext;
            DataContext = new DataContext(StatisModels.ProjectProps.FakeServer);
        }

        public void SetComponentProperties(MachineComponent component)
        {
            CurrentComponent = component;
            if (CurrentComponent.ComponentStocks.Count > 0)
                CurrentStock = CurrentComponent.ComponentStocks[0];
            DS_Component.DataSource = CurrentComponent;
            DS_ComponentStock.DataSource = CurrentStock;
            if (component.ComponentImages.Count > 0)
            {
                CurrentImage = component.ComponentImages[0];
                ComponentPicture.Image = component.ComponentImages[0].Image;
            }
        }


        public void SetComponentProperties(int MachineComponentId)
        {
            try
            {
                using (DataContext = new DataContext(StatisModels.ProjectProps.FakeServer))
                {
                    var component = DataContext.MachineComponent
                        .Include("ComponentImages")
                        .Include("ComponentStocks")
                        .Where(i => i.Id == MachineComponentId)
                        .First();

                    DS_Component.DataSource = CurrentComponent = component;
                    if (component.ComponentStocks.Count > 0)
                        DS_ComponentStock.DataSource = CurrentStock = component.ComponentStocks[0];
                    if (component.ComponentImages.Count > 0)
                    {
                        DS_ComponentImage.DataSource = CurrentImage = component.ComponentImages[0];
                        ComponentPicture.Image = component.ComponentImages[0].Image;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while getting data from database");
            }
        }


        private void ImageParseClickCallback(object sender, EventArgs e)
        {
            // parse the picture from clipboard
            if (!Clipboard.ContainsImage())
                return;

            ComponentPicture.Image = Clipboard.GetImage();
            if (CurrentImage == null)
                CurrentImage = new ComponentImage();
            CurrentImage.SetImage(ComponentPicture.Image);
        }

        public void AddNewComponent()
        {
            try
            {
                using (DataContext = new DataContext(StatisModels.ProjectProps.FakeServer))
                {
                    var sameComponents = DataContext.MachineComponent
                    .Where(i => i.ComponentCode == CurrentComponent.ComponentCode ||
                    i.ComponentName == CurrentComponent.ComponentName);

                    if (sameComponents.Count() > 0)
                    {
                        MessageBox.Show("Component already existed in database");
                        return;
                    }

                    if (CurrentImage.ImageString == null || CurrentImage.ImageString == string.Empty)
                    {
                        MessageBox.Show("Please insert component image");
                        return;
                    }

                    MachineComponent MachineComponent = new MachineComponent(CurrentComponent);

                    MachineComponent.ComponentImages = new List<ComponentImage>(
                        new ComponentImage[]{
                        new ComponentImage{
                            ImageString= CurrentImage.ImageString,
                            ImageName = CurrentImage.ImageName
                        }
                        });

                    MachineComponent.ComponentStocks = new List<ComponentStock>(
                        new ComponentStock[] {
                        new ComponentStock{
                            Quantity = CurrentStock.Quantity,
                            AddUserId = CurrentStock.AddUserId
                        }
                        });

                    DataContext.MachineComponent.Add(MachineComponent);
                    DataContext.SaveChanges();
                }

                MessageBox.Show("Add new component successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not add new component");
            }
        }

        public void UpdateComponent()
        {
            try
            {
                string oldComponent = CurrentComponent.ComponentCode;
                using (DataContext = new DataContext(StatisModels.ProjectProps.FakeServer))
                {
                    ComponentImage currentImage = new ComponentImage();
                    currentImage.ImageString = CurrentImage.ImageString;
                    currentImage.ImageName = CurrentImage.ImageName;

                    if (CurrentComponent.ComponentImages == null || CurrentComponent.ComponentImages.Count == 0)
                    {
                        CurrentComponent.ComponentImages = new List<ComponentImage>(new ComponentImage[] { currentImage });
                    }
                    else
                    if (CurrentComponent.ComponentImages.Count > 0)
                    {
                        CurrentComponent.ComponentImages[0].ImageString = currentImage.ImageString;
                        CurrentComponent.ComponentImages[0].ImageName = currentImage.ImageName;
                    }

                    if (DataContext.Entry(CurrentComponent.ComponentImages[0]).State != System.Data.Entity.EntityState.Modified)
                        DataContext.Entry(CurrentComponent.ComponentImages[0]).State = System.Data.Entity.EntityState.Modified;
                    DataContext.SaveChanges();

                    if (DataContext.Entry(CurrentStock).State != System.Data.Entity.EntityState.Modified)
                        DataContext.Entry(CurrentStock).State = System.Data.Entity.EntityState.Modified;
                    DataContext.SaveChanges();

                    if (DataContext.Entry(CurrentComponent).State != System.Data.Entity.EntityState.Modified)
                        DataContext.Entry(CurrentComponent).State = System.Data.Entity.EntityState.Modified;
                    DataContext.SaveChanges();
                }
                MessageBox.Show($"Update {oldComponent} successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update information failed");
            }
        }

        public void DeleteComponent()
        {
            try
            {
                string oldComponent = CurrentComponent.ComponentCode;

                if (DataContext.Entry(CurrentComponent).State != System.Data.Entity.EntityState.Deleted)
                    DataContext.Entry(CurrentComponent).State = System.Data.Entity.EntityState.Deleted;
                DataContext.SaveChanges();

                MessageBox.Show($"Delete {oldComponent} successfully");
            }
            catch
            {
                MessageBox.Show("Delete component failed");
            }
        }
    }
}
