// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamorgchart.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CreateChartModel
    {
        /// <summary>
        /// Initializes a new instance of the CreateChartModel class.
        /// </summary>
        public CreateChartModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateChartModel class.
        /// </summary>
        public CreateChartModel(string name = default(string), bool? isPublic = default(bool?))
        {
            Name = name;
            IsPublic = isPublic;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPublic")]
        public bool? IsPublic { get; set; }

    }
}
