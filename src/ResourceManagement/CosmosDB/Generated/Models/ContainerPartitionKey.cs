// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration of the partition key to be used for partitioning data
    /// into multiple partitions
    /// </summary>
    public partial class ContainerPartitionKey
    {
        /// <summary>
        /// Initializes a new instance of the ContainerPartitionKey class.
        /// </summary>
        public ContainerPartitionKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerPartitionKey class.
        /// </summary>
        /// <param name="paths">List of paths using which data within the
        /// container can be partitioned</param>
        /// <param name="kind">Indicates the kind of algorithm used for
        /// partitioning. Possible values include: 'Hash', 'Range'</param>
        /// <param name="version">Indicates the version of the partition key
        /// definition</param>
        public ContainerPartitionKey(IList<string> paths = default(IList<string>), PartitionKind kind = default(PartitionKind), int? version = default(int?))
        {
            Paths = paths;
            Kind = kind;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of paths using which data within the container
        /// can be partitioned
        /// </summary>
        [JsonProperty(PropertyName = "paths")]
        public IList<string> Paths { get; set; }

        /// <summary>
        /// Gets or sets indicates the kind of algorithm used for partitioning.
        /// Possible values include: 'Hash', 'Range'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public PartitionKind Kind { get; set; }

        /// <summary>
        /// Gets or sets indicates the version of the partition key definition
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Version > 2)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Version", 2);
            }
            if (Version < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Version", 1);
            }
        }
    }
}
