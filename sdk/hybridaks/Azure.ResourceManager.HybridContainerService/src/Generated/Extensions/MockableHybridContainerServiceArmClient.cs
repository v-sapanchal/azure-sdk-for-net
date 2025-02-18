// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridContainerService;
using Azure.ResourceManager.HybridContainerService.Models;

namespace Azure.ResourceManager.HybridContainerService.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableHybridContainerServiceArmClient : ArmResource
    {
        private ClientDiagnostics _hybridContainerServiceClientDiagnostics;
        private HybridContainerServiceRestOperations _hybridContainerServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableHybridContainerServiceArmClient"/> class for mocking. </summary>
        protected MockableHybridContainerServiceArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHybridContainerServiceArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHybridContainerServiceArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableHybridContainerServiceArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private ClientDiagnostics HybridContainerServiceClientDiagnostics => _hybridContainerServiceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private HybridContainerServiceRestOperations HybridContainerServiceRestClient => _hybridContainerServiceRestClient ??= new HybridContainerServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists the available orchestrators in a custom location for HybridAKS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/orchestrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridContainerService_ListOrchestrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OrchestratorVersionProfileListResult>> GetOrchestratorsHybridContainerServiceAsync(ResourceIdentifier scope, CancellationToken cancellationToken = default)
        {
            using var scope0 = HybridContainerServiceClientDiagnostics.CreateScope("MockableHybridContainerServiceArmClient.GetOrchestratorsHybridContainerService");
            scope0.Start();
            try
            {
                var response = await HybridContainerServiceRestClient.ListOrchestratorsAsync(scope, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the available orchestrators in a custom location for HybridAKS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/orchestrators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridContainerService_ListOrchestrators</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OrchestratorVersionProfileListResult> GetOrchestratorsHybridContainerService(ResourceIdentifier scope, CancellationToken cancellationToken = default)
        {
            using var scope0 = HybridContainerServiceClientDiagnostics.CreateScope("MockableHybridContainerServiceArmClient.GetOrchestratorsHybridContainerService");
            scope0.Start();
            try
            {
                var response = HybridContainerServiceRestClient.ListOrchestrators(scope, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the available VM SKUs in a custom location for HybridAKS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/vmSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridContainerService_ListVMSkus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VmSkuListResult>> GetVmSkusHybridContainerServiceAsync(ResourceIdentifier scope, CancellationToken cancellationToken = default)
        {
            using var scope0 = HybridContainerServiceClientDiagnostics.CreateScope("MockableHybridContainerServiceArmClient.GetVmSkusHybridContainerService");
            scope0.Start();
            try
            {
                var response = await HybridContainerServiceRestClient.ListVmSkusAsync(scope, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the available VM SKUs in a custom location for HybridAKS
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/vmSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HybridContainerService_ListVMSkus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VmSkuListResult> GetVmSkusHybridContainerService(ResourceIdentifier scope, CancellationToken cancellationToken = default)
        {
            using var scope0 = HybridContainerServiceClientDiagnostics.CreateScope("MockableHybridContainerServiceArmClient.GetVmSkusHybridContainerService");
            scope0.Start();
            try
            {
                var response = HybridContainerServiceRestClient.ListVmSkus(scope, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }
        /// <summary>
        /// Gets an object representing a <see cref="ProvisionedClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProvisionedClusterResource.CreateResourceIdentifier" /> to create a <see cref="ProvisionedClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProvisionedClusterResource" /> object. </returns>
        public virtual ProvisionedClusterResource GetProvisionedClusterResource(ResourceIdentifier id)
        {
            ProvisionedClusterResource.ValidateResourceId(id);
            return new ProvisionedClusterResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProvisionedClusterUpgradeProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProvisionedClusterUpgradeProfileResource.CreateResourceIdentifier" /> to create a <see cref="ProvisionedClusterUpgradeProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProvisionedClusterUpgradeProfileResource" /> object. </returns>
        public virtual ProvisionedClusterUpgradeProfileResource GetProvisionedClusterUpgradeProfileResource(ResourceIdentifier id)
        {
            ProvisionedClusterUpgradeProfileResource.ValidateResourceId(id);
            return new ProvisionedClusterUpgradeProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridIdentityMetadataResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridIdentityMetadataResource.CreateResourceIdentifier" /> to create a <see cref="HybridIdentityMetadataResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridIdentityMetadataResource" /> object. </returns>
        public virtual HybridIdentityMetadataResource GetHybridIdentityMetadataResource(ResourceIdentifier id)
        {
            HybridIdentityMetadataResource.ValidateResourceId(id);
            return new HybridIdentityMetadataResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridContainerServiceAgentPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridContainerServiceAgentPoolResource.CreateResourceIdentifier" /> to create a <see cref="HybridContainerServiceAgentPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridContainerServiceAgentPoolResource" /> object. </returns>
        public virtual HybridContainerServiceAgentPoolResource GetHybridContainerServiceAgentPoolResource(ResourceIdentifier id)
        {
            HybridContainerServiceAgentPoolResource.ValidateResourceId(id);
            return new HybridContainerServiceAgentPoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageSpaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageSpaceResource.CreateResourceIdentifier" /> to create a <see cref="StorageSpaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageSpaceResource" /> object. </returns>
        public virtual StorageSpaceResource GetStorageSpaceResource(ResourceIdentifier id)
        {
            StorageSpaceResource.ValidateResourceId(id);
            return new StorageSpaceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridContainerServiceVirtualNetworkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridContainerServiceVirtualNetworkResource.CreateResourceIdentifier" /> to create a <see cref="HybridContainerServiceVirtualNetworkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridContainerServiceVirtualNetworkResource" /> object. </returns>
        public virtual HybridContainerServiceVirtualNetworkResource GetHybridContainerServiceVirtualNetworkResource(ResourceIdentifier id)
        {
            HybridContainerServiceVirtualNetworkResource.ValidateResourceId(id);
            return new HybridContainerServiceVirtualNetworkResource(Client, id);
        }
    }
}
