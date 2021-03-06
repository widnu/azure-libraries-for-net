// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about the auto-storage account associated with a
    /// Batch account.
    /// </summary>
    public partial class AutoStorageProperties : AutoStorageBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the AutoStorageProperties class.
        /// </summary>
        public AutoStorageProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoStorageProperties class.
        /// </summary>
        /// <param name="storageAccountId">The resource ID of the storage
        /// account to be used for auto-storage account.</param>
        /// <param name="lastKeySync">The UTC time at which storage keys were
        /// last synchronized with the Batch account.</param>
        public AutoStorageProperties(string storageAccountId, System.DateTime lastKeySync)
            : base(storageAccountId)
        {
            LastKeySync = lastKeySync;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the UTC time at which storage keys were last
        /// synchronized with the Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "lastKeySync")]
        public System.DateTime LastKeySync { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
