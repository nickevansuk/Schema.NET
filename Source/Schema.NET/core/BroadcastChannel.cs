namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    [DataContract]
    public partial class BroadcastChannel : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastChannel";

        /// <summary>
        /// The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.
        /// </summary>
        [DataMember(Name = "broadcastChannelId", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BroadcastChannelId { get; set; }

        /// <summary>
        /// The type of service required to have access to the channel (e.g. Standard or Premium).
        /// </summary>
        [DataMember(Name = "broadcastServiceTier", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BroadcastServiceTier { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? Genre { get; set; }

        /// <summary>
        /// The CableOrSatelliteService offering the channel.
        /// </summary>
        [DataMember(Name = "inBroadcastLineup", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CableOrSatelliteService>? InBroadcastLineup { get; set; }

        /// <summary>
        /// The BroadcastService offered on this channel.
        /// </summary>
        [DataMember(Name = "providesBroadcastService", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BroadcastService>? ProvidesBroadcastService { get; set; }
    }
}
