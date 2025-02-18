// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AgFoodPlatform;

namespace Azure.ResourceManager.AgFoodPlatform.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableAgFoodPlatformArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAgFoodPlatformArmClient"/> class for mocking. </summary>
        protected MockableAgFoodPlatformArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAgFoodPlatformArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAgFoodPlatformArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableAgFoodPlatformArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="ExtensionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ExtensionResource.CreateResourceIdentifier" /> to create an <see cref="ExtensionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ExtensionResource" /> object. </returns>
        public virtual ExtensionResource GetExtensionResource(ResourceIdentifier id)
        {
            ExtensionResource.ValidateResourceId(id);
            return new ExtensionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FarmBeatsExtensionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FarmBeatsExtensionResource.CreateResourceIdentifier" /> to create a <see cref="FarmBeatsExtensionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FarmBeatsExtensionResource" /> object. </returns>
        public virtual FarmBeatsExtensionResource GetFarmBeatsExtensionResource(ResourceIdentifier id)
        {
            FarmBeatsExtensionResource.ValidateResourceId(id);
            return new FarmBeatsExtensionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FarmBeatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FarmBeatResource.CreateResourceIdentifier" /> to create a <see cref="FarmBeatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FarmBeatResource" /> object. </returns>
        public virtual FarmBeatResource GetFarmBeatResource(ResourceIdentifier id)
        {
            FarmBeatResource.ValidateResourceId(id);
            return new FarmBeatResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AgFoodPlatformPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AgFoodPlatformPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="AgFoodPlatformPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AgFoodPlatformPrivateEndpointConnectionResource" /> object. </returns>
        public virtual AgFoodPlatformPrivateEndpointConnectionResource GetAgFoodPlatformPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            AgFoodPlatformPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new AgFoodPlatformPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AgFoodPlatformPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AgFoodPlatformPrivateLinkResource.CreateResourceIdentifier" /> to create an <see cref="AgFoodPlatformPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AgFoodPlatformPrivateLinkResource" /> object. </returns>
        public virtual AgFoodPlatformPrivateLinkResource GetAgFoodPlatformPrivateLinkResource(ResourceIdentifier id)
        {
            AgFoodPlatformPrivateLinkResource.ValidateResourceId(id);
            return new AgFoodPlatformPrivateLinkResource(Client, id);
        }
    }
}
