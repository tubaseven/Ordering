﻿using System;

namespace ShopiOrderingApp.Application.Feature
{
    public class GetOrderByIdViewModel
    {
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public string StoreName { get; set; }
        public string CustomerName { get; set; }
        public DateTime CreatedOn { get; set; }
      

    }
}
