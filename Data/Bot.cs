namespace SimpleEchoBot.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bot")]
    public partial class Bot
    {
        [Key]
        public int Id { get; set; }

        public int BotTypeId { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        [StringLength(100)]
        public string CodeLocation { get; set; }

        public int EnvironmentId { get; set; }

        public bool Active { get; set; }

        public int? OwnerUserId { get; set; }

        public bool? Premier { get; set; }

        public int? Subscribers { get; set; }

        public int? BotDetailId { get; set; }

        public virtual BotType BotType { get; set; }
    }
}
