using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaksideEscapesBookingSystem.Models
{
    class Pods
    {
        public int PodID { get; set; }
        public string PodType { get; set; }
        public string Capacity { get; set; }
        public int BaseCostPerNight { get; set; }

        public Pods(int podID, string podType, string capacity, int baseCostPerNight)
        {
            PodID = podID;
            PodType = podType;
            Capacity = capacity;
            BaseCostPerNight = baseCostPerNight;
        }

        public Pods()
        {

        }

    }
}
