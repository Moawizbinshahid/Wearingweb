using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Wearingweb.Models
{
    public class AddItem
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string ItemName { get; set; } = "";

        public int ItemPrice { get; set; }

        public int Catagory { get; set; }

    }
}
