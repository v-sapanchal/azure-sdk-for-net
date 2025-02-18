// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> SAS datastore credentials configuration. </summary>
    public partial class MachineLearningSasDatastoreCredentials : MachineLearningDatastoreCredentials
    {
        /// <summary> Initializes a new instance of MachineLearningSasDatastoreCredentials. </summary>
        /// <param name="secrets"> [Required] Storage container secrets. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secrets"/> is null. </exception>
        public MachineLearningSasDatastoreCredentials(MachineLearningSasDatastoreSecrets secrets)
        {
            Argument.AssertNotNull(secrets, nameof(secrets));

            Secrets = secrets;
            CredentialsType = CredentialsType.Sas;
        }

        /// <summary> Initializes a new instance of MachineLearningSasDatastoreCredentials. </summary>
        /// <param name="credentialsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="secrets"> [Required] Storage container secrets. </param>
        internal MachineLearningSasDatastoreCredentials(CredentialsType credentialsType, MachineLearningSasDatastoreSecrets secrets) : base(credentialsType)
        {
            Secrets = secrets;
            CredentialsType = credentialsType;
        }

        /// <summary> [Required] Storage container secrets. </summary>
        public MachineLearningSasDatastoreSecrets Secrets { get; set; }
    }
}
