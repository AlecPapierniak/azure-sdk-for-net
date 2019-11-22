// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A namespace junction.
    /// </summary>
    public partial class NamespaceJunction
    {
        /// <summary>
        /// Initializes a new instance of the NamespaceJunction class.
        /// </summary>
        public NamespaceJunction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NamespaceJunction class.
        /// </summary>
        /// <param name="namespacePath">Namespace path on a Cache for a Storage
        /// Target.</param>
        /// <param name="targetPath">Path in Storage Target to which
        /// namespacePath points.</param>
        /// <param name="nfsExport">NFS export where targetPath exists.</param>
        public NamespaceJunction(string namespacePath = default(string), string targetPath = default(string), string nfsExport = default(string))
        {
            NamespacePath = namespacePath;
            TargetPath = targetPath;
            NfsExport = nfsExport;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets namespace path on a Cache for a Storage Target.
        /// </summary>
        [JsonProperty(PropertyName = "namespacePath")]
        public string NamespacePath { get; set; }

        /// <summary>
        /// Gets or sets path in Storage Target to which namespacePath points.
        /// </summary>
        [JsonProperty(PropertyName = "targetPath")]
        public string TargetPath { get; set; }

        /// <summary>
        /// Gets or sets NFS export where targetPath exists.
        /// </summary>
        [JsonProperty(PropertyName = "nfsExport")]
        public string NfsExport { get; set; }

    }
}
