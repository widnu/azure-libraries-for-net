// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for ProfileResourceState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<ProfileResourceState>))]
    public class ProfileResourceState : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<ProfileResourceState>
    {
        public static readonly ProfileResourceState Creating = Parse("Creating");
        public static readonly ProfileResourceState Active = Parse("Active");
        public static readonly ProfileResourceState Deleting = Parse("Deleting");
        public static readonly ProfileResourceState Disabled = Parse("Disabled");
    }
}
