// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response for a migration of app content request.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageMigrationResponse : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the StorageMigrationResponse class.
        /// </summary>
        public StorageMigrationResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageMigrationResponse class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="operationId">When server starts the migration process,
        /// it will return an operation ID identifying that particular
        /// migration operation.</param>
        public StorageMigrationResponse(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string operationId = default(string))
            : base(id, name, kind, type)
        {
            OperationId = operationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets when server starts the migration process, it will return an
        /// operation ID identifying that particular migration operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationId")]
        public string OperationId { get; private set; }

    }
}
