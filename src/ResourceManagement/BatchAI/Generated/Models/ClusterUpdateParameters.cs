// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cluster update parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ClusterUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ClusterUpdateParameters class.
        /// </summary>
        public ClusterUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterUpdateParameters class.
        /// </summary>
        /// <param name="scaleSettings">Scale settings.</param>
        public ClusterUpdateParameters(ScaleSettings scaleSettings = default(ScaleSettings))
        {
            ScaleSettings = scaleSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets scale settings.
        /// </summary>
        /// <remarks>
        /// Desired scale settings for the cluster. Batch AI service supports
        /// manual and auto scale clusters.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.scaleSettings")]
        public ScaleSettings ScaleSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ScaleSettings != null)
            {
                ScaleSettings.Validate();
            }
        }
    }
}
