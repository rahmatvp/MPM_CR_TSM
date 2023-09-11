using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MPM_CR_TSM.Models
{
    public class parmModel
    {
        public string transId { get; set; }
        public string driverCode { get; set; }
        public string driverName { get; set; }
        public DateTime checkInDateTime { get; set; }
        public DateTime checkOutDateTime { get; set; }
        public string custId { get; set; }
        public string custName { get; set; }
        public string notes { get; set; }
        public decimal usageKMStart { get; set; }
        public decimal usageKMEnd { get; set; }
        public string outOfTown { get; set; }
        public string town_city { get; set; }
        public string nopol { get; set; }
        public string tempDriverCode { get; set; }
        public string typeOfUse { get; set; }
        public string approvedBy { get; set; }
        public DateTime approvedDateTime { get; set; }
        public decimal scoring { get; set; }
        public string picName { get; set; }
        public string approvalType { get; set; }
        public string cmpny { get; set; }
        public string typeOfWork { get; set; }
    }
}