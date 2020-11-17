﻿using System.ComponentModel.DataAnnotations;

namespace Hospital.BLL.DTO.Product
{
    public class ProductCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }

        public int ProductBrandId { get; set; }
        public int ProductTypeId { get; set; }
        public string PictureUrl { get; set; }
    }
}