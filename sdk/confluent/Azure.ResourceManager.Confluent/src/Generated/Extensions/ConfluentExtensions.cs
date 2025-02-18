// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Confluent.Mocking;
using Azure.ResourceManager.Confluent.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Confluent
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Confluent. </summary>
    public static partial class ConfluentExtensions
    {
        private static MockableConfluentArmClient GetMockableConfluentArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableConfluentArmClient(client0));
        }

        private static MockableConfluentResourceGroupResource GetMockableConfluentResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableConfluentResourceGroupResource(client, resource.Id));
        }

        private static MockableConfluentSubscriptionResource GetMockableConfluentSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableConfluentSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ConfluentOrganizationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ConfluentOrganizationResource.CreateResourceIdentifier" /> to create a <see cref="ConfluentOrganizationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentArmClient.GetConfluentOrganizationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ConfluentOrganizationResource" /> object. </returns>
        public static ConfluentOrganizationResource GetConfluentOrganizationResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableConfluentArmClient(client).GetConfluentOrganizationResource(id);
        }

        /// <summary>
        /// Gets a collection of ConfluentOrganizationResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentResourceGroupResource.GetConfluentOrganizations()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ConfluentOrganizationResources and their operations over a ConfluentOrganizationResource. </returns>
        public static ConfluentOrganizationCollection GetConfluentOrganizations(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableConfluentResourceGroupResource(resourceGroupResource).GetConfluentOrganizations();
        }

        /// <summary>
        /// Get the properties of a specific Organization resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentResourceGroupResource.GetConfluentOrganizationAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ConfluentOrganizationResource>> GetConfluentOrganizationAsync(this ResourceGroupResource resourceGroupResource, string organizationName, CancellationToken cancellationToken = default)
        {
            return await GetMockableConfluentResourceGroupResource(resourceGroupResource).GetConfluentOrganizationAsync(organizationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a specific Organization resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentResourceGroupResource.GetConfluentOrganization(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ConfluentOrganizationResource> GetConfluentOrganization(this ResourceGroupResource resourceGroupResource, string organizationName, CancellationToken cancellationToken = default)
        {
            return GetMockableConfluentResourceGroupResource(resourceGroupResource).GetConfluentOrganization(organizationName, cancellationToken);
        }

        /// <summary>
        /// Organization Validate proxy resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/validations/{organizationName}/orgvalidate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Validations_ValidateOrganization</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentResourceGroupResource.ValidateOrganization(string,ConfluentOrganizationData,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="data"> Organization resource model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> or <paramref name="data"/> is null. </exception>
        public static async Task<Response<ConfluentOrganizationResource>> ValidateOrganizationAsync(this ResourceGroupResource resourceGroupResource, string organizationName, ConfluentOrganizationData data, CancellationToken cancellationToken = default)
        {
            return await GetMockableConfluentResourceGroupResource(resourceGroupResource).ValidateOrganizationAsync(organizationName, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Organization Validate proxy resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Confluent/validations/{organizationName}/orgvalidate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Validations_ValidateOrganization</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentResourceGroupResource.ValidateOrganization(string,ConfluentOrganizationData,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="organizationName"> Organization resource name. </param>
        /// <param name="data"> Organization resource model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> or <paramref name="data"/> is null. </exception>
        public static Response<ConfluentOrganizationResource> ValidateOrganization(this ResourceGroupResource resourceGroupResource, string organizationName, ConfluentOrganizationData data, CancellationToken cancellationToken = default)
        {
            return GetMockableConfluentResourceGroupResource(resourceGroupResource).ValidateOrganization(organizationName, data, cancellationToken);
        }

        /// <summary>
        /// List Confluent marketplace agreements in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentSubscriptionResource.GetMarketplaceAgreements(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfluentAgreement" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConfluentAgreement> GetMarketplaceAgreementsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableConfluentSubscriptionResource(subscriptionResource).GetMarketplaceAgreementsAsync(cancellationToken);
        }

        /// <summary>
        /// List Confluent marketplace agreements in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentSubscriptionResource.GetMarketplaceAgreements(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfluentAgreement" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConfluentAgreement> GetMarketplaceAgreements(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableConfluentSubscriptionResource(subscriptionResource).GetMarketplaceAgreements(cancellationToken);
        }

        /// <summary>
        /// Create Confluent Marketplace agreement in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Create</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentSubscriptionResource.CreateMarketplaceAgreement(ConfluentAgreement,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="body"> Confluent Marketplace Agreement resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<ConfluentAgreement>> CreateMarketplaceAgreementAsync(this SubscriptionResource subscriptionResource, ConfluentAgreement body = null, CancellationToken cancellationToken = default)
        {
            return await GetMockableConfluentSubscriptionResource(subscriptionResource).CreateMarketplaceAgreementAsync(body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create Confluent Marketplace agreement in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/agreements/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceAgreements_Create</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentSubscriptionResource.CreateMarketplaceAgreement(ConfluentAgreement,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="body"> Confluent Marketplace Agreement resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<ConfluentAgreement> CreateMarketplaceAgreement(this SubscriptionResource subscriptionResource, ConfluentAgreement body = null, CancellationToken cancellationToken = default)
        {
            return GetMockableConfluentSubscriptionResource(subscriptionResource).CreateMarketplaceAgreement(body, cancellationToken);
        }

        /// <summary>
        /// List all organizations under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentSubscriptionResource.GetConfluentOrganizations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConfluentOrganizationResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ConfluentOrganizationResource> GetConfluentOrganizationsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableConfluentSubscriptionResource(subscriptionResource).GetConfluentOrganizationsAsync(cancellationToken);
        }

        /// <summary>
        /// List all organizations under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Confluent/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organization_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableConfluentSubscriptionResource.GetConfluentOrganizations(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConfluentOrganizationResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ConfluentOrganizationResource> GetConfluentOrganizations(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableConfluentSubscriptionResource(subscriptionResource).GetConfluentOrganizations(cancellationToken);
        }
    }
}
