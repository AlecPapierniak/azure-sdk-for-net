// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Update.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information pertaining to an update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Update : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Update class.
        /// </summary>
        public Update()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Update class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region location of resource.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="dateAvailable">Date uploaded by provider.</param>
        /// <param name="installedDate">Date update was installed.</param>
        /// <param name="description">Description of the update.</param>
        /// <param name="state">Current state of the update. Possible values
        /// include: 'HasPrerequisite', 'Obsolete', 'Ready',
        /// 'NotApplicableBecauseAnotherUpdateIsInProgress', 'Installed',
        /// 'Failed', 'Installing'</param>
        /// <param name="kbLink">Link to the KB article about the
        /// update.</param>
        /// <param name="minVersionRequired">The minimum version required to
        /// install.</param>
        /// <param name="packagePath">Path to the update package.</param>
        /// <param name="packageSizeInMb">Size of update package.</param>
        /// <param name="updateName">Name of the update.</param>
        /// <param name="version">Version of the update.</param>
        /// <param name="updateOemFile">OEM version of the update.</param>
        /// <param name="publisher">Publisher of the update.</param>
        /// <param name="packageType">Describes the components that will be
        /// updated. Possible values include: 'Microsoft', 'Oem',
        /// 'Combined'</param>
        public Update(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? dateAvailable = default(System.DateTime?), System.DateTime? installedDate = default(System.DateTime?), string description = default(string), string state = default(string), string kbLink = default(string), string minVersionRequired = default(string), string packagePath = default(string), long? packageSizeInMb = default(long?), string updateName = default(string), string version = default(string), string updateOemFile = default(string), string publisher = default(string), string packageType = default(string))
            : base(id, name, type, location, tags)
        {
            DateAvailable = dateAvailable;
            InstalledDate = installedDate;
            Description = description;
            State = state;
            KbLink = kbLink;
            MinVersionRequired = minVersionRequired;
            PackagePath = packagePath;
            PackageSizeInMb = packageSizeInMb;
            UpdateName = updateName;
            Version = version;
            UpdateOemFile = updateOemFile;
            Publisher = publisher;
            PackageType = packageType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date uploaded by provider.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dateAvailable")]
        public System.DateTime? DateAvailable { get; set; }

        /// <summary>
        /// Gets or sets date update was installed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.installedDate")]
        public System.DateTime? InstalledDate { get; set; }

        /// <summary>
        /// Gets or sets description of the update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets current state of the update. Possible values include:
        /// 'HasPrerequisite', 'Obsolete', 'Ready',
        /// 'NotApplicableBecauseAnotherUpdateIsInProgress', 'Installed',
        /// 'Failed', 'Installing'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets link to the KB article about the update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.kbLink")]
        public string KbLink { get; set; }

        /// <summary>
        /// Gets or sets the minimum version required to install.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minVersionRequired")]
        public string MinVersionRequired { get; set; }

        /// <summary>
        /// Gets or sets path to the update package.
        /// </summary>
        [JsonProperty(PropertyName = "properties.packagePath")]
        public string PackagePath { get; set; }

        /// <summary>
        /// Gets or sets size of update package.
        /// </summary>
        [JsonProperty(PropertyName = "properties.packageSizeInMb")]
        public long? PackageSizeInMb { get; set; }

        /// <summary>
        /// Gets or sets name of the update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updateName")]
        public string UpdateName { get; set; }

        /// <summary>
        /// Gets or sets version of the update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets OEM version of the update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updateOemFile")]
        public string UpdateOemFile { get; set; }

        /// <summary>
        /// Gets or sets publisher of the update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets describes the components that will be updated.
        /// Possible values include: 'Microsoft', 'Oem', 'Combined'
        /// </summary>
        [JsonProperty(PropertyName = "properties.packageType")]
        public string PackageType { get; set; }

    }
}
