﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.


    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
namespace WebDemo.Models
{
    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product() { }

        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product(string productName = default(string), int? productID = default(int?), int? inStock = default(int?), string productImg = default(string))
        {
            ProductName = productName;
            ProductID = productID;
            InStock = inStock;
            ProductImg = productImg;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductName")]
        public string ProductName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductID")]
        public int? ProductID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InStock")]
        public int? InStock { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProductImg")]
        public string ProductImg { get; set; }



    }
}