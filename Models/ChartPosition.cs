// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamorgchart.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ChartPosition
    {
        /// <summary>
        /// Initializes a new instance of the ChartPosition class.
        /// </summary>
        public ChartPosition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChartPosition class.
        /// </summary>
        public ChartPosition(string managerId, int? id = default(int?), string name = default(string), string friendlyManagerId = default(string), string position = default(string), bool? isTempPosition = default(bool?), System.DateTime? expireDate = default(System.DateTime?), string uniqueId = default(string), string viewItem = default(string), string pictureUrl = default(string), bool? isDepartment = default(bool?), string departmentTitle = default(string), string departmentText = default(string))
        {
            Id = id;
            Name = name;
            ManagerId = managerId;
            FriendlyManagerId = friendlyManagerId;
            Position = position;
            IsTempPosition = isTempPosition;
            ExpireDate = expireDate;
            UniqueId = uniqueId;
            ViewItem = viewItem;
            PictureUrl = pictureUrl;
            IsDepartment = isDepartment;
            DepartmentTitle = departmentTitle;
            DepartmentText = departmentText;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManagerId")]
        public string ManagerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FriendlyManagerId")]
        public string FriendlyManagerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Position")]
        public string Position { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsTempPosition")]
        public bool? IsTempPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExpireDate")]
        public System.DateTime? ExpireDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UniqueId")]
        public string UniqueId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ViewItem")]
        public string ViewItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PictureUrl")]
        public string PictureUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDepartment")]
        public bool? IsDepartment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DepartmentTitle")]
        public string DepartmentTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DepartmentText")]
        public string DepartmentText { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ManagerId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ManagerId");
            }
        }
    }
}
