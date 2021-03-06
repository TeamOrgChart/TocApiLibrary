// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamorgchart.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ChartDefinition
    {
        /// <summary>
        /// Initializes a new instance of the ChartDefinition class.
        /// </summary>
        public ChartDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChartDefinition class.
        /// </summary>
        public ChartDefinition(string orgChartDefinitionId = default(string), string name = default(string), string dataSourceType = default(string), bool? isPublic = default(bool?), bool? isPromoted = default(bool?), int? maximumDepth = default(int?))
        {
            OrgChartDefinitionId = orgChartDefinitionId;
            Name = name;
            DataSourceType = dataSourceType;
            IsPublic = isPublic;
            IsPromoted = isPromoted;
            MaximumDepth = maximumDepth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrgChartDefinitionId")]
        public string OrgChartDefinitionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DataSourceType")]
        public string DataSourceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsPromoted")]
        public bool? IsPromoted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaximumDepth")]
        public int? MaximumDepth { get; set; }

    }
}
