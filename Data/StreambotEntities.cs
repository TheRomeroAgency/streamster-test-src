namespace SimpleEchoBot.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StreambotEntities : DbContext
    {
        public StreambotEntities ()
            : base("name=StreambotEntities")
        {
        }

        public virtual DbSet<Bot> Bots { get; set; }
        public virtual DbSet<BotType> BotTypes { get; set; }
        public virtual DbSet<EnvType> EnvTypes { get; set; }
        public virtual DbSet<SubscriptionType> SubscriptionTypes { get; set; }
        public virtual DbSet<SubscriptionType> Subscriptions { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bot>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Bot>()
                .Property(e => e.CodeLocation)
                .IsUnicode(false);

            modelBuilder.Entity<BotType>()
                .Property(e => e.TypeName)
                .IsUnicode(false);

            modelBuilder.Entity<BotType>()
                .HasMany(e => e.Bots)
                .WithRequired(e => e.BotType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EnvType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }
    }
}
