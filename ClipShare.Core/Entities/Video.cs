using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipShare.Core.Entities
{
    public class Video : BaseEntity
    {
        [Required]
        public String ThumbnailUri { get; set; }

        [Required]
        public String Title { get; set; }

        [Required]
        public String Description { get; set; }


        [Required]
        public String ContentType { get; set; }

        [Required]
        public byte[] Contents { get; set; }

        public int CategoryId { get; set; }

        public int ChannelId { get; set; }

        //Navigation
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("ChannelId")]
        public Channel Channel { get; set; }


    }
}
