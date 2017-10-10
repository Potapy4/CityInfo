using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.API.Entities
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(512)]
        public string Name { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        public ICollection<PointOfInterest> PointsOfInterest { get; set; } = new List<PointOfInterest>();
    }
}
