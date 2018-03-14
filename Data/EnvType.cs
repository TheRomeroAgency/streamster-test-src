namespace SimpleEchoBot.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EnvType")]
    public partial class EnvType
    {
        public int EnvTypeId { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }
    }
}
