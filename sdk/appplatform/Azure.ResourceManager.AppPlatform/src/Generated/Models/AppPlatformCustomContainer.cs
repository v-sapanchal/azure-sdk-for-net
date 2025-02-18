// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Custom container payload. </summary>
    public partial class AppPlatformCustomContainer
    {
        /// <summary> Initializes a new instance of AppPlatformCustomContainer. </summary>
        public AppPlatformCustomContainer()
        {
            Command = new ChangeTrackingList<string>();
            Args = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppPlatformCustomContainer. </summary>
        /// <param name="server"> The name of the registry that contains the container image. </param>
        /// <param name="containerImage"> Container image of the custom container. This should be in the form of &lt;repository&gt;:&lt;tag&gt; without the server name of the registry. </param>
        /// <param name="command"> Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. </param>
        /// <param name="args"> Arguments to the entrypoint. The docker image's CMD is used if this is not provided. </param>
        /// <param name="imageRegistryCredential"> Credential of the image registry. </param>
        /// <param name="languageFramework"> Language framework of the container image uploaded. </param>
        internal AppPlatformCustomContainer(string server, string containerImage, IList<string> command, IList<string> args, AppPlatformImageRegistryCredential imageRegistryCredential, string languageFramework)
        {
            Server = server;
            ContainerImage = containerImage;
            Command = command;
            Args = args;
            ImageRegistryCredential = imageRegistryCredential;
            LanguageFramework = languageFramework;
        }

        /// <summary> The name of the registry that contains the container image. </summary>
        public string Server { get; set; }
        /// <summary> Container image of the custom container. This should be in the form of &lt;repository&gt;:&lt;tag&gt; without the server name of the registry. </summary>
        public string ContainerImage { get; set; }
        /// <summary> Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. </summary>
        public IList<string> Command { get; }
        /// <summary> Arguments to the entrypoint. The docker image's CMD is used if this is not provided. </summary>
        public IList<string> Args { get; }
        /// <summary> Credential of the image registry. </summary>
        public AppPlatformImageRegistryCredential ImageRegistryCredential { get; set; }
        /// <summary> Language framework of the container image uploaded. </summary>
        public string LanguageFramework { get; set; }
    }
}
