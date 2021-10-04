using DoAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.ViewModels
{
    public class HomeIndexVM
    {
        public List<TravelModel> TravelModels { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}
