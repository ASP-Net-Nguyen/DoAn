using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class Status
    {
        public int Id { get; set; }
        [DisplayName("Trạng thái")]
        public string Statuss { get; set; }
        public List<TravelModel> TravelModels { get; set; }
    }
}
