using DebugTracker.Data.Entities;
using DebugTracker.Data.ViewsDb;
using Microsoft.EntityFrameworkCore;

namespace Icta.RequestTracker.Data
{
    public class DebugTrackerDbContext : DbContext
    {
        public DebugTrackerDbContext()
        {

        }

        public DebugTrackerDbContext(DbContextOptions<DebugTrackerDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Views
            modelBuilder.Entity<VStudy>().HasNoKey().ToView("vw_GLOBAL_Study");
            modelBuilder.Entity<VGlobalPersonnel>().HasNoKey().ToView("vw_GLOBAL_PERSONNEL");
            #endregion

            #region relation between MS-System-Location

            modelBuilder.Entity<MacroSystem_System>().HasKey(ms => new { ms.MacroSystemId, ms.SystemId });
            modelBuilder.Entity<System_Location>().HasKey(s => new { s.SystemId, s.LocationId });

            modelBuilder.Entity<MacroSystem_System>()
                .HasOne(ms => ms.MacroSystem)
                .WithMany(mss => mss.MacroSystem_Systems)
                .HasForeignKey(msId => msId.MacroSystemId);

            modelBuilder.Entity<System_Location>()
                .HasOne(s => s.System)
                .WithMany(sl => sl.System_Locations)
                .HasForeignKey(msId => msId.SystemId);

            modelBuilder.Entity<System_Location>()
                .HasOne(s => s.Location)
                .WithMany(sl => sl.System_Locations)
                .HasForeignKey(msId => msId.LocationId);

            modelBuilder.Entity<Request>()
                .HasOne(x => x.MacroSystem)
                .WithMany()
                .HasForeignKey(x => x.MacroSystemId);

            #endregion 

            #region RequestStatus
            modelBuilder.Entity<Request>()
                .HasMany(x => x.RequestStatus)
                .WithOne()
                .HasForeignKey(x => x.RequestId);

            //modelBuilder.Entity<Request_Status>()
            //    .HasOne(x => x.Request)
            //    .WithMany(y => y.RequestStatus)
            //    .HasForeignKey(z => z.RequestId);
            #endregion

            #region Seed
            modelBuilder.Entity<MacroSystem>().HasData(
                new MacroSystem { Id = 1, Label = "- Undefined -", FullLabel = "- Undefined -", OrderBy = 0 },
                new MacroSystem { Id = 2, Label = "SR", FullLabel = "Systems and Networks(SR)", OrderBy = 1 },
                new MacroSystem { Id = 3, Label = "DI", FullLabel = "Computerized developments (DI)", OrderBy = 2 },
                new MacroSystem { Id = 4, Label = "BI", FullLabel = "Biometrics (BI)", OrderBy = 3 }
                );

            modelBuilder.Entity<SystemEntity>().HasData(
                new SystemEntity { Id = 1, Label = "- Undefined -", OrderBy = 0 },
                new SystemEntity { Id = 2, Label = "i-Cloud", OrderBy = 1 }


                );

            modelBuilder.Entity<Location>().HasData(
                new Location { Id = 1, Label = "- Undefined -", OrderBy = 0 },
                new Location { Id = 2, Label = "Global", OrderBy = 1 }
                );

            modelBuilder.Entity<MacroSystem_System>().HasData(
                new MacroSystem_System { MacroSystemId = 1, SystemId = 1 },
                new MacroSystem_System { MacroSystemId = 2, SystemId = 1 }
                );

            modelBuilder.Entity<System_Location>().HasData(
                new System_Location { SystemId = 1, LocationId = 1 },
                new System_Location { SystemId = 2, LocationId = 1 }
                );

            #endregion

        }

        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<VStudy> VStudy { get; set; }
        public virtual DbSet<VGlobalPersonnel> VGlobalPersonnels { get; set; }
        public virtual DbSet<MacroSystem> MacroSytems { get; set; }
        public virtual DbSet<SystemEntity> Systems { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MacroSystem_System> MacroSystem_Systems { get; set; }
        public virtual DbSet<System_Location> System_Locations { get; set; }
        public virtual DbSet<RequestStatus> RequestStatus{ get; set; }

    }

}


