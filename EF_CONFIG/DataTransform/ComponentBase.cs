using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Models;
using EF_CONFIG.Data;

namespace EF_CONFIG.DataTransform
{
    public static class ComponentBase
    {
        public static MachineComponent Get_Component(int id)
        {
            try
            {
                using (DataContext DataContext = new DataContext(Server.RealDb))
                {
                    return DataContext.MachineComponent.Find(id);
                }
            }
            catch { return null; }
        }

        public static List<MachineComponent> Get_Components(string ComponentCategory)
        {
            try
            {
                using (DataContext DataContext = new DataContext(Server.RealDb))
                {
                    return DataContext.MachineComponent
                       .Where(i => i.ComponentCategory.Contains(ComponentCategory))
                       .ToList();
                }
            }
            catch { return null; }
        }

        public static List<ComponentStock> Get_ComponentStock(int MachineComponentId)
        {
            try
            {
                using (DataContext DataContext = new DataContext(Server.RealDb))
                {
                    return DataContext.ComponentStock
                       .Where(i => i.MachineComponentId == MachineComponentId)
                       .ToList();
                }
            }
            catch { return null; }
        }

        public static MachineComponent Get_Knife(int LocalId)
        {
            try
            {
                var components = Get_Components("Knife");
                if (components == null)
                    return null;

                return components.Where(i => i.LocalSetupId == LocalId).FirstOrDefault();
            }
            catch { return null; }
        }
    }
}
