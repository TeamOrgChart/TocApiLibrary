// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamorgchart.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ChartDataView
    {
        /// <summary>
        /// Initializes a new instance of the ChartDataView class.
        /// </summary>
        public ChartDataView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChartDataView class.
        /// </summary>
        public ChartDataView(string chartId = default(string), string startValue = default(string), int? depth = default(int?), IList<ChartNode> data = default(IList<ChartNode>))
        {
            ChartId = chartId;
            StartValue = startValue;
            Depth = depth;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "chartId")]
        public string ChartId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startValue")]
        public string StartValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Data")]
        public IList<ChartNode> Data { get; set; }

    }
}
