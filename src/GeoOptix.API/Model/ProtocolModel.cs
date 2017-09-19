/* 
   Copyright 2017 Sitka Technology Group LLC

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace GeoOptix.API.Model
{
    public class ProtocolModel : ProtocolSummaryModel
    {
        [JsonProperty("datasetInfo")]
        public IEnumerable<DatasetInfo> DatasetInfo { get; set; }

        [Obsolete]
        public ProtocolModel() 
        {
            
        }

        public ProtocolModel(int id, string name, string displayName, string description, string documentFolder, string url, IEnumerable<DatasetInfo> datasetInfo) : base(id, name, displayName, description, documentFolder, url)
        {
            DatasetInfo = datasetInfo;
        }
    }

    public class DatasetInfo
    {
        [JsonProperty("datasetTypeId")]
        public int DatasetTypeId { get; set; }

        [JsonProperty("datasetType")]
        public string DatasetType { get; set; }

        [JsonProperty("datasetTypeFullName")]
        public string DatasetTypeFullName { get; set; }

        [JsonProperty("notMeasuredReasonListID")]
        public int? NotMeasuredReasonListID { get; set; }

        [JsonProperty("dataCollectionGroups")]
        public IEnumerable<DataCollectionGroupModel> DataCollectionGroups { get; set; }
        
        [JsonProperty("componentTypes")]
        public IEnumerable<ComponentTypeModel> ComponentTypes { get; set; }
        
        [JsonProperty("summarizations")]
        public IEnumerable<SummarizationModel> Summarizations { get; set; }
        
        [JsonProperty("summarizationLevels")]
        public IEnumerable<SummarizationLevelModel> SummarizationLevels { get; set; }
        
        [JsonProperty("summarizationFunctions")]
        public IEnumerable<SummarizationFunctionModel> SummarizationFunctions { get; set; }
        
        [JsonProperty("dataTypes")]
        public IEnumerable<DataTypeModel> DataType { get; set; }
        
        [JsonProperty("unitOfMeasures")]
        public IEnumerable<UnitOfMeasureModel> UnitOfMeasures { get; set; }
        
        //[JsonProperty("domainValueLists")]
        //public IEnumerable<DomainValueListModel> DomainValueLists { get; set; }

        [JsonProperty("domainValueListUrl")]
        public string DomainValueListUrl { get; set; }


        public DatasetInfo() { }
    }

    public class DataCollectionGroupModel
    {
        [JsonProperty("collectionGroupId")]
        public int CollectionGroupId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("isRequiredForVisit")]
        public bool IsRequiredForVisit { get; set; }

        [JsonProperty("displayOrderId")]
        public int DisplayOrderId { get; set; }
        
        public DataCollectionGroupModel() { }
    }

    public class ComponentTypeModel
    {
        [JsonProperty("componentTypeId")]
        public int ComponentTypeId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayNamePlural")]
        public string DisplayNamePlural { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("displayOrderId")]
        public int DisplayOrderId { get; set; }

        [JsonProperty("countMinRowsRequired")]
        public byte? CountMinRowsRequired { get; set; }

        [JsonProperty("countMaxAllowed")]
        public int? CountMaxAllowed { get; set; }

        [JsonProperty("countMinRequired")]
        public int? CountMinRequired { get; set; }

        [JsonProperty("countMinRowsPerParent")]
        public byte? CountMinRowsPerParent { get; set; }

        [JsonProperty("countMaxRowsPerParent")]
        public byte? CountMaxRowsPerParent { get; set; }

        [JsonProperty("componentTypeCD")]
        public string ComponentTypeCD { get; set; }

        [JsonProperty("fileNameFilterRegex")]
        public string FileNameFilterRegex { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("filenameExtension")]
        public string FilenameExtension { get; set; }

        [JsonProperty("notMeasReasonListIdTable")]
        public int? NotMeasReasonListIdTable { get; set; }

        [JsonProperty("notMeasReasonListIdRecord")]
        public int? NotMeasReasonListIdRecord { get; set; }

        [JsonProperty("collectionGroupId")]
        public short? CollectionGroupId { get; set; }
        
        [JsonProperty("inputGroups")]
        public IEnumerable<InputGroupModel> InputGroups { get; set; }
        
        [JsonProperty("inputFields")]
        public IEnumerable<InputFieldModel> InputFields { get; set; }
        
        public ComponentTypeModel() { }
    }

    public class InputGroupModel
    {
        [JsonProperty("inputGroupId")]
        public int InputGroupId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("loggerLayoutName")]
        public string LoggerLayoutName { get; set; }

        [JsonProperty("loggerLayoutId")]
        public byte? LoggerLayoutId { get; set; }

        [JsonProperty("loggerDisplayOrderId")]
        public int? LoggerDisplayOrderId { get; set; }

        [JsonProperty("notMeasListReasonId")]
        public int? NotMeasListReasonId { get; set; }

        [JsonProperty("isCustomInput")]
        public bool IsCustomInput { get; set; }
        
        public InputGroupModel() { }
    }

    public class InputFieldModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("warnOnEmpty")]
        public bool WarnOnEmpty { get; set; }

        [JsonProperty("lockOnOverlay")]
        public bool LockOnOverlay { get; set; }

        [JsonProperty("isAutoNumber")]
        public bool IsAutoNumber { get; set; }

        [JsonProperty("isCalculated")]
        public bool IsCalculated { get; set; }

        [JsonProperty("isUnique")]
        public bool IsUnique { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("dataTypeId")]
        public int DataTypeId { get; set; }

        [JsonProperty("measAttribId")]
        public int MeasAttribId { get; set; }

        [JsonProperty("loggerLayoutName")]
        public string LoggerLayoutName { get; set; }

        [JsonProperty("loggerLayoutId")]
        public byte? LoggerLayoutId { get; set; }

        [JsonProperty("loggerDisplayOrderId")]
        public int? LoggerDisplayOrderId { get; set; }

        [JsonProperty("uomid")]
        public byte? Uomid { get; set; }
        
        public InputFieldModel() { }
    }

    public class SummarizationModel
    {

        [JsonProperty("summarizationId")]
        public int SummarizationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("displayOrderId")]
        public int DisplayOrderId { get; set; }

        [JsonProperty("summarizationLevelId")]
        public int SummarizationLevelId { get; set; }
        
        [JsonProperty("aggregations")]
        public IEnumerable<AggregationModel> Aggregations { get; set; }
        
        public SummarizationModel() { }
    }

    public class AggregationModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("displayOrderId")]
        public int DisplayOrderId { get; set; }

        [JsonProperty("measAttribId")]
        public short MeasAttribId { get; set; }

        [JsonProperty("summarizationFunctionId")]
        public byte SummarizationFunctionId { get; set; }
        
        public AggregationModel() { }
    }

    public class SummarizationLevelModel
    {
        [JsonProperty("summarizationLevelId")]
        public int SummarizationLevelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }
        
        public SummarizationLevelModel() { }

    }

    public class SummarizationFunctionModel
    {
        [JsonProperty("summarizationFunctionId")]
        public short SummarizationFunctionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }
        
        public SummarizationFunctionModel() { }
    }

    public class DataTypeModel
    {
        [JsonProperty("dataTypeId")]
        public byte DataTypeId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("hasLength")]
        public bool HasLength { get; set; }

        [JsonProperty("hasScale")]
        public bool HasScale { get; set; }

        [JsonProperty("hasPrecision")]
        public bool HasPrecision { get; set; }

        [JsonProperty("isNumericType")]
        public bool IsNumericType { get; set; }
        
        public DataTypeModel() { }

    }

    public class UnitOfMeasureModel
    {
        [JsonProperty("uomid")]
        public int Uomid { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
        
        public UnitOfMeasureModel() { }
    }

    public class DomainValueListModel
    {
        [JsonProperty("listId")]
        public int ListId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("listItems")]
        public IEnumerable<ListItemModel> ListItems { get; set; }
        
        public DomainValueListModel() { }

        public DomainValueListModel(int listID, string displayName, IEnumerable<ListItemModel> listItems)
        {
            ListId = listID;
            DisplayName = displayName;
            ListItems = listItems.OrderBy(x => x.DisplayOrderId);
        }
    }

    public class ListItemModel
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("displayOrderId")]
        public int DisplayOrderId { get; set; }
        
        public ListItemModel() { }
    }
}

