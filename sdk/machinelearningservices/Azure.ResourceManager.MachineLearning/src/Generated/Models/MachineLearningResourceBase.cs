// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningResourceBase. </summary>
    public partial class MachineLearningResourceBase
    {
        /// <summary> Initializes a new instance of MachineLearningResourceBase. </summary>
        public MachineLearningResourceBase()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of MachineLearningResourceBase. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        internal MachineLearningResourceBase(string description, IDictionary<string, string> properties, IDictionary<string, string> tags)
        {
            Description = description;
            Properties = properties;
            Tags = tags;
        }

        /// <summary> The asset description text. </summary>
        public string Description { get; set; }
        /// <summary> The asset property dictionary. </summary>
        public IDictionary<string, string> Properties { get; set; }
        /// <summary> Tag dictionary. Tags can be added, removed, and updated. </summary>
        public IDictionary<string, string> Tags { get; set; }
    }
}
