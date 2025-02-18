// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Column transformer parameters. </summary>
    public partial class ColumnTransformer
    {
        /// <summary> Initializes a new instance of ColumnTransformer. </summary>
        public ColumnTransformer()
        {
            Fields = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ColumnTransformer. </summary>
        /// <param name="fields"> Fields to apply transformer logic on. </param>
        /// <param name="parameters">
        /// Different properties to be passed to transformer.
        /// Input expected is dictionary of key,value pairs in JSON format.
        /// </param>
        internal ColumnTransformer(IList<string> fields, BinaryData parameters)
        {
            Fields = fields;
            Parameters = parameters;
        }

        /// <summary> Fields to apply transformer logic on. </summary>
        public IList<string> Fields { get; set; }
        /// <summary>
        /// Different properties to be passed to transformer.
        /// Input expected is dictionary of key,value pairs in JSON format.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Parameters { get; set; }
    }
}
