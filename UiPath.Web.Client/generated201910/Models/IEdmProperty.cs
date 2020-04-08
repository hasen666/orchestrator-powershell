// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IEdmProperty
    {
        /// <summary>
        /// Initializes a new instance of the IEdmProperty class.
        /// </summary>
        public IEdmProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmProperty class.
        /// </summary>
        /// <param name="propertyKind">Possible values include: 'None',
        /// 'Structural', 'Navigation'</param>
        public IEdmProperty(IEdmPropertyPropertyKind? propertyKind = default(IEdmPropertyPropertyKind?), IEdmTypeReference type = default(IEdmTypeReference), IEdmStructuredType declaringType = default(IEdmStructuredType), string name = default(string))
        {
            PropertyKind = propertyKind;
            Type = type;
            DeclaringType = declaringType;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets possible values include: 'None', 'Structural', 'Navigation'
        /// </summary>
        [JsonProperty(PropertyName = "PropertyKind")]
        public IEdmPropertyPropertyKind? PropertyKind { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public IEdmTypeReference Type { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DeclaringType")]
        public IEdmStructuredType DeclaringType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

    }
}