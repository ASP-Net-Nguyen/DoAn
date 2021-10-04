using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class TravelTag
    {
        public int Id { get; set; }
        public int TravelModelId { get; set; }
        public int TagId { get; set; }
        public TravelModel TravelModel { get; set; }
        public Tag Tag { get; set; }
    }
}
