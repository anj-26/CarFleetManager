using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CarDetails.Models;

public class Cars
{
        [Key]
        public int RegistrationId { get; set; }

        public string Brand { get; set; }

        public DateTime FirstInspection { get; set; }

        public DateTime LastInspection { get; set; }

        public bool IsRoadWorthy { get; set; }

        public DateTime NextInspection { get; set; }
        
        public bool IsInspectionExpired { get; set; }
      
}
