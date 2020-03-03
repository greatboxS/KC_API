using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CONFIG.Data;
using EF_CONFIG.Models;

namespace EF_CONFIG.Data
{
    public static class DB_Init
    {
        public static void SetupDb( DataContext DataContext)
        {
            try
            {
                if (!DataContext.Database.Exists())
                {
                    DataContext.Database.Create();

                    DataContext.Database.ExecuteSqlCommand("DROP TABLE [__MigrationHistory]");
                    DataContext.SaveChanges();

                    DataContext.Building.AddRange(new Building[]
                    {
                        new Building{BuildingName= "L Building",
                            AutoCutMachines = new List<AutoCutMachine>(new AutoCutMachine[]{
                                new AutoCutMachine{ MachineName = "L1", ResetCounterDate = "Mon" },
                                new AutoCutMachine{ MachineName = "L2", ResetCounterDate = "Mon" },
                                new AutoCutMachine{ MachineName = "L3", ResetCounterDate = "Mon" },
                                new AutoCutMachine{ MachineName = "L4", ResetCounterDate = "Mon" },
                                new AutoCutMachine{ MachineName = "L5", ResetCounterDate = "Mon" },
                                new AutoCutMachine{ MachineName = "L6", ResetCounterDate = "Mon" } }
                        ),
                            KC_Devices =  new List<KC_Device>(new KC_Device[]{
                            new KC_Device{ DeviceName = "KC1_L" },
                            new KC_Device{ DeviceName = "KC2_L" }})
                        },
                        new Building{BuildingName= "P Building",
                            AutoCutMachines = new List<AutoCutMachine>(new AutoCutMachine[]{
                            new AutoCutMachine{ MachineName = "P1", ResetCounterDate = "Mon" },
                            new AutoCutMachine{ MachineName = "P2", ResetCounterDate = "Mon" },
                            new AutoCutMachine{ MachineName = "P3", ResetCounterDate = "Mon" },
                            new AutoCutMachine{ MachineName = "P4", ResetCounterDate = "Mon" } }
                        ),
                            KC_Devices =  new List<KC_Device>(new KC_Device[]{
                            new KC_Device{ DeviceName = "KC_P1" }})
                        },
                        new Building{BuildingName= "J Building",
                            AutoCutMachines = new List<AutoCutMachine>(new AutoCutMachine[]{
                            new AutoCutMachine{ MachineName = "J1", ResetCounterDate = "Mon" },
                            new AutoCutMachine{ MachineName = "J2", ResetCounterDate = "Mon" },
                            new AutoCutMachine{ MachineName = "J3", ResetCounterDate = "Mon" } }
                        ),
                            KC_Devices =  new List<KC_Device>(new KC_Device[]{
                            new KC_Device{ DeviceName = "KC_J1" }})
                        },
                        new Building{BuildingName= "M Building",
                            AutoCutMachines = new List<AutoCutMachine>(new AutoCutMachine[]{
                            new AutoCutMachine{ MachineName = "M1", ResetCounterDate = "Mon" } }
                        ),
                            KC_Devices =  new List<KC_Device>(new KC_Device[]{
                            new KC_Device{ DeviceName = "KC_M1" }})
                        },
                        new Building{BuildingName= "E Building",
                            AutoCutMachines = new List<AutoCutMachine>(new AutoCutMachine[]{
                            new AutoCutMachine{ MachineName = "E1", ResetCounterDate = "Mon" },
                            new AutoCutMachine{ MachineName = "E2", ResetCounterDate = "Mon" },
                            new AutoCutMachine{ MachineName = "E3", ResetCounterDate = "Mon" },
                            new AutoCutMachine{ MachineName = "E4", ResetCounterDate = "Mon" } }
                        ),
                            KC_Devices =  new List<KC_Device>(new KC_Device[]{
                            new KC_Device{ DeviceName = "KC_E1" }})
                        }
                    });

                    DataContext.MachineComponent.AddRange(new MachineComponent[]
                    {
                        new MachineComponent{ ComponentCategory = "ATOM Knife", ComponentCode = "#46251",
                            ComponentName = "46251", Unit="Cái", LocalSetupId = 1},
                        new MachineComponent{ ComponentCategory = "ATOM Knife", ComponentCode = "#30782",
                            ComponentName = "30782", Unit="Cái", LocalSetupId = 2},
                        new MachineComponent{ ComponentCategory = "ATOM Knife", ComponentCode = "#New knife",
                            ComponentName = "New knife", Unit="Cái", LocalSetupId = 3},
                        new MachineComponent{ ComponentCategory = "ATOM Knife", ComponentCode = "#New knife",
                            ComponentName = "46251", Unit="Cái", LocalSetupId = 4},
                        
                        new MachineComponent{ ComponentCategory = "EMMA Knife", ComponentCode = "#32104",
                            ComponentName = "32104", Unit="Cái", LocalSetupId = 5},
                        new MachineComponent{ ComponentCategory = "EMMA Knife", ComponentCode = "#35104",
                            ComponentName = "35104", Unit="Cái", LocalSetupId = 6},
                        new MachineComponent{ ComponentCategory = "EMMA Knife", ComponentCode = "#35115",
                            ComponentName = "35115", Unit="Cái", LocalSetupId = 7},
                        new MachineComponent{ ComponentCategory = "EMMA Knife", ComponentCode = "#New knife",
                            ComponentName = "New knife", Unit="Cái", LocalSetupId = 8},
                        new MachineComponent{ ComponentCategory = "EMMA Knife", ComponentCode = "#New knife",
                            ComponentName = "New knife", Unit="Cái", LocalSetupId = 9},
                    });

                    DataContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
