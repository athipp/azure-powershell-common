// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.ResourceManager.Version2018_05_01.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment information.
    /// </summary>
    public partial class DeploymentExtended : IResource
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentExtended class.
        /// </summary>
        public DeploymentExtended()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentExtended class.
        /// </summary>
        /// <param name="id">The ID of the deployment.</param>
        /// <param name="name">The name of the deployment.</param>
        /// <param name="location">the location of the deployment.</param>
        /// <param name="properties">Deployment properties.</param>
        public DeploymentExtended(string id = default(string), string name = default(string), string location = default(string), DeploymentPropertiesExtended properties = default(DeploymentPropertiesExtended))
        {
            Id = id;
            Name = name;
            Location = location;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the location of the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets deployment properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DeploymentPropertiesExtended Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
