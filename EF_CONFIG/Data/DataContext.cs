using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using EF_CONFIG.Models;

namespace EF_CONFIG.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }
        public DataContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<KnifeCaptureTracking> KnifeCaptureTracking { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<AutoCutMachine> AutoCutMachine { get; set; }
        public DbSet<KC_Device> KC_Device { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<MachineMaintenance> MachineMaintenance { get; set; }
        public DbSet<ComponentStock> ComponentStock { get; set; }
        public DbSet<MachineComponent> MachineComponent { get; set; }
        public DbSet<AutoCutDivision> AutoCutDivision { get; set; }
        public DbSet<ComponentImage> ComponentImage { get; set; }
        public DbSet<KC_DisMachine> KC_DisMachine { get; set; }
        public DbSet<KC_PostRecord> KC_PostRecord { get; set; }
        public DbSet<KC_MachineInitialize> KC_MachineInitialize { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>()
                .HasMany(i => i.AutoCutMachines)
                .WithRequired(i => i.Building)
                .HasForeignKey(k => k.BuildingId);

            modelBuilder.Entity<Building>()
                .HasMany(i => i.KC_Devices)
                .WithRequired(i => i.Building)
                .HasForeignKey(k => k.BuildingId);

            modelBuilder.Entity<AutoCutMachine>()
                .HasMany(i => i.KnifeCaptureTrackings)
                .WithRequired(i => i.AutoCutMachine)
                .HasForeignKey(i => i.MachineId);

            modelBuilder.Entity<KC_Device>()
                .HasMany(i => i.KnifeCaptureTrackings)
                .WithOptional(i => i.KC_Device)
                .HasForeignKey(i => i.KC_DeviceId);

            modelBuilder.Entity<Building>()
                .HasMany(i => i.KC_PostRecords)
                .WithOptional(i => i.Building)
                .HasForeignKey(k => k.BuildingId);

            modelBuilder.Entity<KC_Device>()
                .HasMany(i => i.KC_DisMachines)
                .WithOptional(i => i.KC_Device)
                .HasForeignKey(k => k.KC_DeviceId);

            modelBuilder.Entity<KC_Device>()
                .HasMany(i => i.KC_PostRecords)
                .WithOptional(i => i.KC_Device)
                .HasForeignKey(k => k.KC_DeviceId);

            modelBuilder.Entity<KC_PostRecord>()
                .HasMany(i => i.KC_DisMachines)
                .WithOptional(i => i.KC_PostRecord)
                .HasForeignKey(k => k.KC_PostRecordId);

            modelBuilder.Entity<KC_MachineInitialize>()
                .HasOptional(i => i.AutoCutMachine)
                .WithMany(i => i.KC_MachineInitializes)
                .HasForeignKey(k => k.AutoCutMachineId);


            ///////////////////////////////////////////////
            modelBuilder.Entity<AutoCutDivision>()
                .HasMany(i => i.Buildings)
                .WithOptional(i => i.AutoCutDivision)
                .HasForeignKey(k => k.DivisionId);

            modelBuilder.Entity<Building>()
                .HasMany(i => i.AutoCutMachines)
                .WithOptional(i => i.Building)
                .HasForeignKey(k => k.BuildingId);

            modelBuilder.Entity<Building>()
                .HasMany(i => i.MachineMaintenances)
                .WithOptional(i => i.Building)
                .HasForeignKey(k => k.BuildingId);

            modelBuilder.Entity<MachineMaintenance>()
                .HasOptional(i => i.AutoCutMachine)
                .WithMany(i => i.MachineMaintenances)
                .HasForeignKey(k => k.AutoCutMachineId);

            modelBuilder.Entity<MachineMaintenance>()
                .HasOptional(i => i.Staff)
                .WithMany(i => i.MachineMaintenances)
                .HasForeignKey(k => k.AuthorPeopleId);

            modelBuilder.Entity<MachineMaintenance>()
                .HasOptional(i => i.AutoCutMachine)
                .WithMany(i => i.MachineMaintenances)
                .HasForeignKey(k => k.AutoCutMachineId);

            modelBuilder.Entity<MachineMaintenance>()
                .HasOptional(i => i.MachineComponent)
                .WithMany(i => i.MachineMaintenances)
                .HasForeignKey(k => k.MachineComponentId);

            modelBuilder.Entity<ComponentStock>()
                .HasOptional(i => i.AddUser)
                .WithMany(i => i.ComponentStocks)
                .HasForeignKey(k => k.AddUserId);

            modelBuilder.Entity<ComponentStock>()
                .HasOptional(i => i.MachineComponent)
                .WithMany(i => i.ComponentStocks)
                .HasForeignKey(k => k.MachineComponentId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<MachineComponent>()
                .HasMany(i => i.ComponentImages)
                .WithOptional(i => i.MachineComponent)
                .HasForeignKey(i => i.MachineComponentId)
                .WillCascadeOnDelete(true);
        }
    }
}
