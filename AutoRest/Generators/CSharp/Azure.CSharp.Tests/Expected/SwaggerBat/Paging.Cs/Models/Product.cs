namespace Fixtures.Azure.SwaggerBatPaging.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Azure;

    /// <summary>
    /// </summary>
    public partial class Product
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ProductProperties Properties { get; set; }

    }
}