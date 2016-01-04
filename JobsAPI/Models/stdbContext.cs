namespace JobsAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class stdbContext : DbContext
    {
        public stdbContext()
            : base("name=stdbContext")
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Alert> Alerts { get; set; }
        public virtual DbSet<ApplicationResourceLock> ApplicationResourceLocks { get; set; }
        public virtual DbSet<ApplicationSetting> ApplicationSettings { get; set; }
        public virtual DbSet<AttributeCategory> AttributeCategories { get; set; }
        public virtual DbSet<AttributeGroup> AttributeGroups { get; set; }
        public virtual DbSet<AttributeInfo> AttributeInfoes { get; set; }
        public virtual DbSet<AttributeTypeString> AttributeTypeStrings { get; set; }
        public virtual DbSet<Checkpoint> Checkpoints { get; set; }
        public virtual DbSet<ConditionalJobAttribute> ConditionalJobAttributes { get; set; }
        public virtual DbSet<ContactList> ContactLists { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<DestinationDevice> DestinationDevices { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceSelectionModeString> DeviceSelectionModeStrings { get; set; }
        public virtual DbSet<DeviceTypeString> DeviceTypeStrings { get; set; }
        public virtual DbSet<EventCategory> EventCategories { get; set; }
        public virtual DbSet<EventLog> EventLogs { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventTypeString> EventTypeStrings { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FileTypeString> FileTypeStrings { get; set; }
        public virtual DbSet<FilterAtom> FilterAtoms { get; set; }
        public virtual DbSet<FilterOperatorString> FilterOperatorStrings { get; set; }
        public virtual DbSet<Filter> Filters { get; set; }
        public virtual DbSet<Folder> Folders { get; set; }
        public virtual DbSet<FolderScope> FolderScopes { get; set; }
        public virtual DbSet<FolderType> FolderTypes { get; set; }
        public virtual DbSet<JobAncestor> JobAncestors { get; set; }
        public virtual DbSet<JobMedium> JobMediums { get; set; }
        public virtual DbSet<JobMessage> JobMessages { get; set; }
        public virtual DbSet<JobPriorityString> JobPriorityStrings { get; set; }
        public virtual DbSet<JobReconciliation> JobReconciliations { get; set; }
        public virtual DbSet<JobReconciliationBatch> JobReconciliationBatches { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobSelection> JobSelections { get; set; }
        public virtual DbSet<JobStateGroupString> JobStateGroupStrings { get; set; }
        public virtual DbSet<JobStateString> JobStateStrings { get; set; }
        public virtual DbSet<JobTicketTypeString> JobTicketTypeStrings { get; set; }
        public virtual DbSet<MessageTypeString> MessageTypeStrings { get; set; }
        public virtual DbSet<MonitorConditionalJobAttribute> MonitorConditionalJobAttributes { get; set; }
        public virtual DbSet<MonitorFileNameAttribute> MonitorFileNameAttributes { get; set; }
        public virtual DbSet<Monitor> Monitors { get; set; }
        public virtual DbSet<OrphanedJob> OrphanedJobs { get; set; }
        public virtual DbSet<SchemaVersion> SchemaVersions { get; set; }
        public virtual DbSet<Selection> Selections { get; set; }
        public virtual DbSet<SiteDeletion> SiteDeletions { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<SiteUpdate> SiteUpdates { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<StorageFolder> StorageFolders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserJobFilter> UserJobFilters { get; set; }
        public virtual DbSet<Workflow> Workflows { get; set; }
        public virtual DbSet<WorkflowTransaction> WorkflowTransactions { get; set; }
        public virtual DbSet<AccessControl> AccessControls { get; set; }
        public virtual DbSet<AggregateJob> AggregateJobs { get; set; }
        public virtual DbSet<JobDisplayColumn> JobDisplayColumns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttributeCategory>()
                .HasMany(e => e.AttributeInfoes)
                .WithRequired(e => e.AttributeCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AttributeGroup>()
                .HasMany(e => e.AttributeInfoes)
                .WithRequired(e => e.AttributeGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AttributeInfo>()
                .HasMany(e => e.JobDisplayColumns)
                .WithRequired(e => e.AttributeInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AttributeInfo>()
                .HasMany(e => e.FilterAtoms)
                .WithRequired(e => e.AttributeInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AttributeTypeString>()
                .HasMany(e => e.AttributeInfoes)
                .WithRequired(e => e.AttributeTypeString)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Checkpoint>()
                .HasMany(e => e.Activities)
                .WithRequired(e => e.Checkpoint)
                .HasForeignKey(e => e.ActivityEndCheckpointID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Checkpoint>()
                .HasMany(e => e.ApplicationResourceLocks)
                .WithOptional(e => e.Checkpoint)
                .HasForeignKey(e => e.LockedCheckpointID);

            modelBuilder.Entity<ConditionalJobAttribute>()
                .HasMany(e => e.MonitorConditionalJobAttributes)
                .WithRequired(e => e.ConditionalJobAttribute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContactList>()
                .HasMany(e => e.Contacts)
                .WithMany(e => e.ContactLists)
                .Map(m => m.ToTable("ContactListContacts").MapLeftKey("ContactListID").MapRightKey("ContactID"));

            modelBuilder.Entity<Destination>()
                .HasMany(e => e.DestinationDevices)
                .WithRequired(e => e.Destination)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Destination>()
                .HasMany(e => e.Stations)
                .WithMany(e => e.Destinations)
                .Map(m => m.ToTable("StationDestinations").MapLeftKey("DestinationID").MapRightKey("StationID"));

            modelBuilder.Entity<Device>()
                .HasMany(e => e.DestinationDevices)
                .WithRequired(e => e.Device)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeviceSelectionModeString>()
                .HasMany(e => e.Destinations)
                .WithRequired(e => e.DeviceSelectionModeString)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeviceTypeString>()
                .HasMany(e => e.Devices)
                .WithRequired(e => e.DeviceTypeString)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventCategory>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.EventCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Alerts)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventLogs)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventTypeString>()
                .HasMany(e => e.EventLogs)
                .WithRequired(e => e.EventTypeString)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FilterOperatorString>()
                .HasMany(e => e.FilterAtoms)
                .WithRequired(e => e.FilterOperatorString)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Filter>()
                .HasMany(e => e.Alerts)
                .WithRequired(e => e.Filter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Filter>()
                .HasMany(e => e.ConditionalJobAttributes)
                .WithRequired(e => e.Filter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Filter>()
                .HasMany(e => e.FilterAtoms)
                .WithRequired(e => e.Filter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Filter>()
                .HasMany(e => e.UserJobFilters)
                .WithRequired(e => e.Filter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Folder>()
                .HasMany(e => e.Folders1)
                .WithOptional(e => e.Folder1)
                .HasForeignKey(e => e.ParentFolderID);

            modelBuilder.Entity<Folder>()
                .HasMany(e => e.Sites)
                .WithRequired(e => e.Folder)
                .HasForeignKey(e => e.SiteJobFolderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Folder>()
                .HasMany(e => e.Stations)
                .WithRequired(e => e.Folder)
                .HasForeignKey(e => e.StationFolderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Folder>()
                .HasMany(e => e.UserJobFilters)
                .WithOptional(e => e.Folder)
                .HasForeignKey(e => e.JobFilterFolderID);

            modelBuilder.Entity<FolderScope>()
                .HasMany(e => e.Folders)
                .WithRequired(e => e.FolderScope)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FolderType>()
                .HasMany(e => e.Folders)
                .WithRequired(e => e.FolderType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobReconciliationBatch>()
                .HasMany(e => e.JobReconciliations)
                .WithRequired(e => e.JobReconciliationBatch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.ConditionalJobAttributes)
                .WithRequired(e => e.Job)
                .HasForeignKey(e => e.TemplateJobID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.JobMessages)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Jobs1)
                .WithOptional(e => e.Job1)
                .HasForeignKey(e => e.ParentJobID);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.JobSelections)
                .WithRequired(e => e.Job)
                .HasForeignKey(e => e.SelectedJobID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MessageTypeString>()
                .HasMany(e => e.JobMessages)
                .WithRequired(e => e.MessageTypeString)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Monitor>()
                .HasMany(e => e.ApplicationResourceLocks)
                .WithOptional(e => e.Monitor)
                .HasForeignKey(e => e.LockedMonitorID);

            modelBuilder.Entity<Monitor>()
                .HasMany(e => e.MonitorConditionalJobAttributes)
                .WithRequired(e => e.Monitor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Monitor>()
                .HasMany(e => e.MonitorFileNameAttributes)
                .WithRequired(e => e.Monitor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Selection>()
                .HasMany(e => e.JobSelections)
                .WithRequired(e => e.Selection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Site>()
                .HasMany(e => e.JobReconciliationBatches)
                .WithRequired(e => e.Site)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StorageFolder>()
                .HasMany(e => e.Files)
                .WithRequired(e => e.StorageFolder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StorageFolder>()
                .HasMany(e => e.Monitors)
                .WithRequired(e => e.StorageFolder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Workflow>()
                .HasMany(e => e.Activities)
                .WithRequired(e => e.Workflow)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Workflow>()
                .HasMany(e => e.WorkflowTransactions)
                .WithRequired(e => e.Workflow)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessControl>()
                .Property(e => e.TrusteeSID)
                .IsUnicode(false);
        }
    }
}
