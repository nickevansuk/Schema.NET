namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A collection of datasets.
    /// </summary>
    [DataContract]
    public partial class DataCatalog : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataCatalog";

        /// <summary>
        /// A dataset contained in this catalog.
        /// </summary>
        [DataMember(Name = "dataset", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Dataset>? Dataset { get; set; }
    }
}
