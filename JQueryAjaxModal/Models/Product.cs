using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JQueryAjaxModal.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Tên sản phẩm")]
        [StringLength(maximumLength: 100, MinimumLength = 10, ErrorMessage = "Độ dài chuỗi từ 10 đến 100")]
        public string ProductName { get; set; }
        [Required]
        [DisplayName("Tên nhà sản xuất")]
        public string Producer { get; set; }
        public bool Status { get; set; }

    }
}
