﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Models.ViewModels.Abstract
{
    public abstract class ProductViewModel
    {
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public string VideoUrl { get; set; }
        public string PictureUrl1 { get; set; }
        public string PictureUrl2 { get; set; }
        public string PictureUrl3 { get; set; }
        public string PictureUrl4 { get; set; }
        public string PictureUrl5 { get; set; }
        public string PictureUrl6 { get; set; }
        public string PictureUrl7 { get; set; }
        public string PictureUrl8 { get; set; }
    }
}