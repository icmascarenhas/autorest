
namespace Petstore.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Tag
    {
        /// <summary>
        /// Initializes a new instance of the Tag class.
        /// </summary>
        public Tag() { }

        /// <summary>
        /// Initializes a new instance of the Tag class.
        /// </summary>
        public Tag(long? id = default(long?), string name = default(string))
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}