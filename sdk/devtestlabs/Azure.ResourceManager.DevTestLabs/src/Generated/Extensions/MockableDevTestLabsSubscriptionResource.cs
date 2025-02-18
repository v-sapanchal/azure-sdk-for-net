// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DevTestLabs;

namespace Azure.ResourceManager.DevTestLabs.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableDevTestLabsSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _devTestLabLabsClientDiagnostics;
        private LabsRestOperations _devTestLabLabsRestClient;
        private ClientDiagnostics _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics;
        private GlobalSchedulesRestOperations _devTestLabGlobalScheduleGlobalSchedulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableDevTestLabsSubscriptionResource"/> class for mocking. </summary>
        protected MockableDevTestLabsSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDevTestLabsSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDevTestLabsSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DevTestLabLabsClientDiagnostics => _devTestLabLabsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabResource.ResourceType.Namespace, Diagnostics);
        private LabsRestOperations DevTestLabLabsRestClient => _devTestLabLabsRestClient ??= new LabsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DevTestLabResource.ResourceType));
        private ClientDiagnostics DevTestLabGlobalScheduleGlobalSchedulesClientDiagnostics => _devTestLabGlobalScheduleGlobalSchedulesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DevTestLabs", DevTestLabGlobalScheduleResource.ResourceType.Namespace, Diagnostics);
        private GlobalSchedulesRestOperations DevTestLabGlobalScheduleGlobalSchedulesRestClient => _devTestLabGlobalScheduleGlobalSchedulesRestClient ??= new GlobalSchedulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DevTestLabGlobalScheduleResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List labs in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevTestLab/labs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabResource> GetDevTestLabsAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DevTestLabLabsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DevTestLabLabsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevTestLabResource(Client, DevTestLabData.DeserializeDevTestLabData(e)), DevTestLabLabsClientDiagnostics, Pipeline, "MockableDevTestLabsSubscriptionResource.GetDevTestLabs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List labs in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevTestLab/labs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Labs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabResource> GetDevTestLabs(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DevTestLabLabsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DevTestLabLabsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevTestLabResource(Client, DevTestLabData.DeserializeDevTestLabData(e)), DevTestLabLabsClientDiagnostics, Pipeline, "MockableDevTestLabsSubscriptionResource.GetDevTestLabs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List schedules in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevTestLab/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DevTestLabGlobalScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DevTestLabGlobalScheduleResource> GetDevTestLabGlobalSchedulesAsync(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DevTestLabGlobalScheduleGlobalSchedulesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DevTestLabGlobalScheduleGlobalSchedulesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DevTestLabGlobalScheduleResource(Client, DevTestLabScheduleData.DeserializeDevTestLabScheduleData(e)), DevTestLabGlobalScheduleGlobalSchedulesClientDiagnostics, Pipeline, "MockableDevTestLabsSubscriptionResource.GetDevTestLabGlobalSchedules", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List schedules in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevTestLab/schedules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalSchedules_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specify the $expand query. Example: 'properties($select=status)'. </param>
        /// <param name="filter"> The filter to apply to the operation. Example: '$filter=contains(name,'myName'). </param>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: '$top=10'. </param>
        /// <param name="orderby"> The ordering expression for the results, using OData notation. Example: '$orderby=name desc'. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DevTestLabGlobalScheduleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DevTestLabGlobalScheduleResource> GetDevTestLabGlobalSchedules(string expand = null, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DevTestLabGlobalScheduleGlobalSchedulesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, expand, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DevTestLabGlobalScheduleGlobalSchedulesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, expand, filter, top, orderby);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DevTestLabGlobalScheduleResource(Client, DevTestLabScheduleData.DeserializeDevTestLabScheduleData(e)), DevTestLabGlobalScheduleGlobalSchedulesClientDiagnostics, Pipeline, "MockableDevTestLabsSubscriptionResource.GetDevTestLabGlobalSchedules", "value", "nextLink", cancellationToken);
        }
    }
}
