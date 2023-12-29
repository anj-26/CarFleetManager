using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDetails.Models;

namespace CarDetails.DTOs;

public class CarDTO
{
        public int RegistrationId { get; set; }
        public string Brand { get; set; }
        public DateTime FirstInspection { get; set; }
        public DateTime LastInspection { get; set; }
        public bool IsRoadWorthy { get; set; }
        public DateTime NextInspection { get; set; }
        public bool IsInspectionExpired { get; set; }
}
