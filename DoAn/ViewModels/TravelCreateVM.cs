using Microsoft.AspNetCore.Mvc.Rendering;
using DoAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.ViewModels
{
    public class TravelCreateVM
    {
        public TravelModel TravelModel { get; set; }
        public IEnumerable<SelectListItem> StatusSelectList { get; set; }
        public IEnumerable<SelectListItem> TagSelectList { get; set; }
        public IEnumerable<int> SelectListTagIds { get; set; }
    }
}
