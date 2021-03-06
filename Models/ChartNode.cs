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

    public partial class ChartNode
    {
        /// <summary>
        /// Initializes a new instance of the ChartNode class.
        /// </summary>
        public ChartNode()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChartNode class.
        /// </summary>
        public ChartNode(int? boxType = default(int?), int? virtualLevel = default(int?), string searchName = default(string), string uniqueId = default(string), string managerId = default(string), string originalManagerId = default(string), string managerDisplayName = default(string), string mappedId = default(string), string mappedManagerDisplayName = default(string), string displayName = default(string), string jobTitle = default(string), string email = default(string), string phone = default(string), string group = default(string), string pictureUrl = default(string), bool? isAssistant = default(bool?), bool? hasHiddenReports = default(bool?), bool? isCoordinator = default(bool?), bool? isJointManager = default(bool?), bool? isDropLevel = default(bool?), bool? isDropLevelParent = default(bool?), int? height = default(int?), int? width = default(int?), bool? isDepartment = default(bool?), bool? isVacantPosition = default(bool?), bool? isTempPosition = default(bool?), VacantPositionViewModel vacantPosition = default(VacantPositionViewModel), bool? isChartAddition = default(bool?), IList<ChartNode> assistants = default(IList<ChartNode>), IList<ChartNode> coordinators = default(IList<ChartNode>), IList<ChartNode> jointManagers = default(IList<ChartNode>), IDictionary<string, string> tOCImpacts = default(IDictionary<string, string>), IDictionary<string, string> tOCFields = default(IDictionary<string, string>), ChartLayoutViewModel chartLayout = default(ChartLayoutViewModel))
        {
            BoxType = boxType;
            VirtualLevel = virtualLevel;
            SearchName = searchName;
            UniqueId = uniqueId;
            ManagerId = managerId;
            OriginalManagerId = originalManagerId;
            ManagerDisplayName = managerDisplayName;
            MappedId = mappedId;
            MappedManagerDisplayName = mappedManagerDisplayName;
            DisplayName = displayName;
            JobTitle = jobTitle;
            Email = email;
            Phone = phone;
            Group = group;
            PictureUrl = pictureUrl;
            IsAssistant = isAssistant;
            HasHiddenReports = hasHiddenReports;
            IsCoordinator = isCoordinator;
            IsJointManager = isJointManager;
            IsDropLevel = isDropLevel;
            IsDropLevelParent = isDropLevelParent;
            Height = height;
            Width = width;
            IsDepartment = isDepartment;
            IsVacantPosition = isVacantPosition;
            IsTempPosition = isTempPosition;
            VacantPosition = vacantPosition;
            IsChartAddition = isChartAddition;
            Assistants = assistants;
            Coordinators = coordinators;
            JointManagers = jointManagers;
            TOCImpacts = tOCImpacts;
            TOCFields = tOCFields;
            ChartLayout = chartLayout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BoxType")]
        public int? BoxType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VirtualLevel")]
        public int? VirtualLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SearchName")]
        public string SearchName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UniqueId")]
        public string UniqueId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManagerId")]
        public string ManagerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OriginalManagerId")]
        public string OriginalManagerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManagerDisplayName")]
        public string ManagerDisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MappedId")]
        public string MappedId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MappedManagerDisplayName")]
        public string MappedManagerDisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JobTitle")]
        public string JobTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Group")]
        public string Group { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PictureUrl")]
        public string PictureUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAssistant")]
        public bool? IsAssistant { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasHiddenReports")]
        public bool? HasHiddenReports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsCoordinator")]
        public bool? IsCoordinator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsJointManager")]
        public bool? IsJointManager { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDropLevel")]
        public bool? IsDropLevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDropLevelParent")]
        public bool? IsDropLevelParent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Height")]
        public int? Height { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Width")]
        public int? Width { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsDepartment")]
        public bool? IsDepartment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsVacantPosition")]
        public bool? IsVacantPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsTempPosition")]
        public bool? IsTempPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VacantPosition")]
        public VacantPositionViewModel VacantPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsChartAddition")]
        public bool? IsChartAddition { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Assistants")]
        public IList<ChartNode> Assistants { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Coordinators")]
        public IList<ChartNode> Coordinators { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JointManagers")]
        public IList<ChartNode> JointManagers { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TOC_Impacts")]
        public IDictionary<string, string> TOCImpacts { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TOC_Fields")]
        public IDictionary<string, string> TOCFields { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChartLayout")]
        public ChartLayoutViewModel ChartLayout { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VacantPosition != null)
            {
                VacantPosition.Validate();
            }
            if (Assistants != null)
            {
                foreach (var element in Assistants)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Coordinators != null)
            {
                foreach (var element1 in Coordinators)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (JointManagers != null)
            {
                foreach (var element2 in JointManagers)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
