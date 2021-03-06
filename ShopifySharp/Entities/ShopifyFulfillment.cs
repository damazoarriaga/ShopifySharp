﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify fulfillment.
    /// </summary>
    public class ShopifyFulfillment : ShopifyObject
    {
        /// <summary>
        /// The date and time when the fulfillment was created. 
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// A historical record of each item in the fulfillment.
        /// </summary>
        [JsonProperty("line_items")]
        public IEnumerable<ShopifyLineItem> LineItems { get; set; }

        /// <summary>
        /// The unique numeric identifier for the order.
        /// </summary>
        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// A textfield with information about the receipt.
        /// </summary>
        [JsonProperty("receipt")]
        public object Receipt { get; set; }

        /// <summary>
        /// The status of the fulfillment. Valid values are 'pending', 'success', 'cancelled', 
        /// 'error' and 'failure'.
        /// </summary>
        /// <remarks>
        /// This class and property were created before the 
        /// <see cref="ShopifySharp.Converters.NullableEnumConverter{T}"/>. It should be converted to an 
        /// enum in v2.0.
        /// </remarks>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The name of the shipping company.
        /// </summary>
        [JsonProperty("tracking_company")]
        public string TrackingCompany { get; set; }

        /// <summary>
        /// The shipping number, provided by the shipping company. If multiple tracking numbers
        /// exist (<see cref="TrackingNumbers"/>), returns the first number.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// A list of shipping numbers, provided by the shipping company. May be null.
        /// </summary>
        [JsonProperty("tracking_numbers")]
        public IEnumerable<string> TrackingNumbers { get; set; }

        /// <summary>
        /// The tracking url, provided by the shipping company. May be null. If multiple tracking URLs
        /// exist (<see cref="TrackingUrls"/>), returns the first URL.
        /// </summary>
        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// An array of one or more tracking urls, provided by the shipping company. May be null.
        /// </summary>
        [JsonProperty("tracking_urls")]
        public IEnumerable<string> TrackingUrls { get; set; }

        /// <summary>
        /// The date and time when the fulfillment was last modified.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
