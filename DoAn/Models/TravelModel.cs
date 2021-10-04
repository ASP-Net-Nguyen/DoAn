using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Models
{
    public class TravelModel
    {
        public int Id { get; set; }
        [Required, DisplayName("Nhập tên địa điểm")]
        public string NameTravel { get; set; }
        [Required, DisplayName("Nhập địa chỉ")]
        public string AuthorTravel { get; set; }
        [Required, DisplayName("Nhập thông tin")]
        public string Infomation { get; set; }
        [Required, DisplayName("Nhập thông tin")]
        public string Infomation1 { get; set; }
        [Required, DisplayName("Nhập thông tin")]
        public string Infomation2 { get; set; }
        [Required, DisplayName("Nhập thứ tự")]
        [Range(1, int.MaxValue, ErrorMessage =("Số phai lớn hơn 0, và hơn số trước + 1"))]
        public int DisplayTravel { get; set; }
        [Required, DisplayName("Hình ảnh")]
        public string ImageUrl { get; set; }
        [Required, DisplayName("Hình ảnh")]
        public string ImageUrl1 { get; set; }
        [Required, DisplayName("Hình ảnh")]
        public string ImageUrl2 { get; set; }
        [Required, DisplayName("Hình ảnh")]
        public string ImageUrl3 { get; set; }
        [Required, DisplayName("Hình ảnh")]
        public string ImageUrl4 { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        /*public List<TravelTag> TravelTags { get; set; } = new List<TravelTag>();*/
    }
}
