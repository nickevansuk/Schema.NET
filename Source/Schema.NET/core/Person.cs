namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    [DataContract]
    public partial class Person : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Person";

        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        [DataMember(Name = "additionalName", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AdditionalName { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PostalAddress, string>? Address { get; set; }

        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        [DataMember(Name = "affiliation", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? Affiliation { get; set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        [DataMember(Name = "alumniOf", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<EducationalOrganization, Organization>? AlumniOf { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Award { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [DataMember(Name = "birthDate", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? BirthDate { get; set; }

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        [DataMember(Name = "birthPlace", Order = 8)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? BirthPlace { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 9)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Brand, Organization>? Brand { get; set; }

        /// <summary>
        /// A child of the person.
        /// </summary>
        [DataMember(Name = "children", Order = 10)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Children { get; set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        [DataMember(Name = "colleague", Order = 11)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Uri>? Colleague { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 12)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ContactPoint>? ContactPoint { get; set; }

        /// <summary>
        /// Date of death.
        /// </summary>
        [DataMember(Name = "deathDate", Order = 13)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DeathDate { get; set; }

        /// <summary>
        /// The place where the person died.
        /// </summary>
        [DataMember(Name = "deathPlace", Order = 14)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? DeathPlace { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 15)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 16)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Email { get; set; }

        /// <summary>
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        /// </summary>
        [DataMember(Name = "familyName", Order = 17)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FamilyName { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 18)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FaxNumber { get; set; }

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        [DataMember(Name = "follows", Order = 19)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Follows { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 20)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Funder { get; set; }

        /// <summary>
        /// Gender of the person. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender.
        /// </summary>
        [DataMember(Name = "gender", Order = 21)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, GenderType?>? Gender { get; set; }

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        /// </summary>
        [DataMember(Name = "givenName", Order = 22)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? GivenName { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 23)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 24)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OfferCatalog>? HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 25)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? HasPOS { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 26)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Distance, QuantitativeValue>? Height { get; set; }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        [DataMember(Name = "homeLocation", Order = 27)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place, ContactPoint>? HomeLocation { get; set; }

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        [DataMember(Name = "honorificPrefix", Order = 28)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? HonorificPrefix { get; set; }

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        [DataMember(Name = "honorificSuffix", Order = 29)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? HonorificSuffix { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 30)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? IsicV4 { get; set; }

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        [DataMember(Name = "jobTitle", Order = 31)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? JobTitle { get; set; }

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        [DataMember(Name = "knows", Order = 32)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Knows { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 33)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? MakesOffer { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 34)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, ProgramMembership>? MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 35)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Naics { get; set; }

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        [DataMember(Name = "nationality", Order = 36)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Country>? Nationality { get; set; }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        [DataMember(Name = "netWorth", Order = 37)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MonetaryAmount, PriceSpecification>? NetWorth { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 38)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Product, OwnershipInfo>? Owns { get; set; }

        /// <summary>
        /// A parent of this person.
        /// </summary>
        [DataMember(Name = "parent", Order = 39)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Parent { get; set; }

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        [DataMember(Name = "performerIn", Order = 40)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? PerformerIn { get; set; }

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        [DataMember(Name = "relatedTo", Order = 41)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? RelatedTo { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 42)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Demand>? Seeks { get; set; }

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        [DataMember(Name = "sibling", Order = 43)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Sibling { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 44)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Sponsor { get; set; }

        /// <summary>
        /// The person's spouse.
        /// </summary>
        [DataMember(Name = "spouse", Order = 45)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Spouse { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 46)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 47)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 48)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VatID { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [DataMember(Name = "weight", Order = 49)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? Weight { get; set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        [DataMember(Name = "workLocation", Order = 50)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place, ContactPoint>? WorkLocation { get; set; }

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        [DataMember(Name = "worksFor", Order = 51)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? WorksFor { get; set; }
    }
}
