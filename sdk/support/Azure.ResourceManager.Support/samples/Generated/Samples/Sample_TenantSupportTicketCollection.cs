// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Support;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_TenantSupportTicketCollection
    {
        // List support tickets created on or after a certain date and in open state for a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSupportTicketsCreatedOnOrAfterACertainDateAndInOpenStateForASubscription()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/ListSupportTicketsCreatedOnOrAfterAndInOpenState.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation and iterate over the result
            string filter = "createdDate ge 2020-03-10T22:08:51Z and status eq 'Open'";
            await foreach (TenantSupportTicketResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List support tickets created on or after a certain date and in updating state for a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSupportTicketsCreatedOnOrAfterACertainDateAndInUpdatingStateForASubscription()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/ListSupportTicketsCreatedOnOrAfterAndInUpdatingState.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation and iterate over the result
            string filter = "createdDate ge 2020-03-10T22:08:51Z and status eq 'Updating'";
            await foreach (TenantSupportTicketResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List support tickets for a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSupportTicketsForASubscription()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/ListSupportTickets.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation and iterate over the result
            await foreach (TenantSupportTicketResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List support tickets in open state for a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSupportTicketsInOpenStateForASubscription()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/ListSupportTicketsInOpenState.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation and iterate over the result
            string filter = "status eq 'Open'";
            await foreach (TenantSupportTicketResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List support tickets in updating state for a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSupportTicketsInUpdatingStateForASubscription()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/ListSupportTicketsInUpdatingState.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation and iterate over the result
            string filter = "status eq 'Updating'";
            await foreach (TenantSupportTicketResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List support tickets with a certain problem classification id for a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSupportTicketsWithACertainProblemClassificationIdForASubscription()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/ListSupportTicketsProblemClassificationIdEquals.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation and iterate over the result
            string filter = "ProblemClassificationId eq 'compute_vm_problemClassification_guid'";
            await foreach (TenantSupportTicketResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List support tickets with a certain service id for a subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSupportTicketsWithACertainServiceIdForASubscription()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/ListSupportTicketsServiceIdEquals.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation and iterate over the result
            string filter = "ServiceId eq 'vm_windows_service_guid'";
            await foreach (TenantSupportTicketResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get details of a ticket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDetailsOfATicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/GetSupportTicketDetails.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation
            string supportTicketName = "testticket";
            TenantSupportTicketResource result = await collection.GetAsync(supportTicketName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get details of a ticket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetDetailsOfATicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/GetSupportTicketDetails.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation
            string supportTicketName = "testticket";
            bool result = await collection.ExistsAsync(supportTicketName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get details of a ticket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetDetailsOfATicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/GetSupportTicketDetails.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation
            string supportTicketName = "testticket";
            NullableResponse<TenantSupportTicketResource> response = await collection.GetIfExistsAsync(supportTicketName);
            TenantSupportTicketResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SupportTicketData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create a ticket for Billing related issues
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateATicketForBillingRelatedIssues()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/CreateBillingSupportTicket.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation
            string supportTicketName = "testticket";
            SupportTicketData data = new SupportTicketData()
            {
                Description = "my description",
                ProblemClassificationId = "/providers/Microsoft.Support/services/billing_service_guid/problemClassifications/billing_problemClassification_guid",
                Severity = SupportSeverityLevel.Moderate,
                SupportPlanId = "U291cmNlOlNDTSxDbGFyaWZ5SW5zdGFsbGF0aW9uU2l0ZUlkOjcsTGluZUl0ZW1JZDo5ODY1NzIyOSxDb250cmFjdElkOjk4NjU5MTk0LFN1YnNjcmlwdGlvbklkOjc2Y2I3N2ZhLThiMTctNGVhYi05NDkzLWI2NWRhY2U5OTgxMyw=",
                ContactDetails = new SupportContactProfile("abc", "xyz", PreferredContactMethod.Email, "abc@contoso.com", "Pacific Standard Time", "usa", "en-US"),
                Title = "my title",
                ServiceId = "/providers/Microsoft.Support/services/billing_service_guid",
                FileWorkspaceName = "6f16735c-1530836f-e9970f1a-2e49-47b7-96cd-9746b83aa066",
            };
            ArmOperation<TenantSupportTicketResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, supportTicketName, data);
            TenantSupportTicketResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a ticket for Subscription Management related issues
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateATicketForSubscriptionManagementRelatedIssues()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/CreateSubMgmtSupportTicket.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation
            string supportTicketName = "testticket";
            SupportTicketData data = new SupportTicketData()
            {
                Description = "my description",
                ProblemClassificationId = "/providers/Microsoft.Support/services/subscription_management_service_guid/problemClassifications/subscription_management_problemClassification_guid",
                Severity = SupportSeverityLevel.Moderate,
                SupportPlanId = "U291cmNlOlNDTSxDbGFyaWZ5SW5zdGFsbGF0aW9uU2l0ZUlkOjcsTGluZUl0ZW1JZDo5ODY1NzIyOSxDb250cmFjdElkOjk4NjU5MTk0LFN1YnNjcmlwdGlvbklkOjc2Y2I3N2ZhLThiMTctNGVhYi05NDkzLWI2NWRhY2U5OTgxMyw=",
                ContactDetails = new SupportContactProfile("abc", "xyz", PreferredContactMethod.Email, "abc@contoso.com", "Pacific Standard Time", "usa", "en-US"),
                Title = "my title",
                ServiceId = "/providers/Microsoft.Support/services/subscription_management_service_guid",
                FileWorkspaceName = "6f16735c-1530836f-e9970f1a-2e49-47b7-96cd-9746b83aa066",
            };
            ArmOperation<TenantSupportTicketResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, supportTicketName, data);
            TenantSupportTicketResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a ticket for Technical issue related to a specific resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateATicketForTechnicalIssueRelatedToASpecificResource()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2022-09-01-preview/examples/CreateTechnicalSupportTicket.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this TenantSupportTicketResource
            TenantSupportTicketCollection collection = tenantResource.GetTenantSupportTickets();

            // invoke the operation
            string supportTicketName = "testticket";
            SupportTicketData data = new SupportTicketData()
            {
                Description = "my description",
                ProblemClassificationId = "/providers/Microsoft.Support/services/virtual_machine_running_linux_service_guid/problemClassifications/problemClassification_guid",
                Severity = SupportSeverityLevel.Moderate,
                AdvancedDiagnosticConsent = AdvancedDiagnosticConsent.Yes,
                ProblemScopingQuestions = "{\"articleId\":\"076846c1-4c0b-4b21-91c6-1a30246b3867\",\"scopingDetails\":[{\"question\":\"When did the problem begin?\",\"controlId\":\"problem_start_time\",\"orderId\":1,\"inputType\":\"static\",\"answer\":{\"displayValue\":\"2023-08-31T18:55:00.739Z\",\"value\":\"2023-08-31T18:55:00.739Z\",\"type\":\"datetime\"}},{\"question\":\"API Type of the Cosmos DB account\",\"controlId\":\"api_type\",\"orderId\":2,\"inputType\":\"static\",\"answer\":{\"displayValue\":\"Table\",\"value\":\"tables\",\"type\":\"string\"}},{\"question\":\"Table name\",\"controlId\":\"collection_name_table\",\"orderId\":11,\"inputType\":\"nonstatic\",\"answer\":{\"displayValue\":\"Select Table Name\",\"value\":\"dont_know_answer\",\"type\":\"string\"}},{\"question\":\"Provide additional details about the issue you're facing\",\"controlId\":\"problem_description\",\"orderId\":12,\"inputType\":\"nonstatic\",\"answer\":{\"displayValue\":\"test ticket, please ignore and close\",\"value\":\"test ticket, please ignore and close\",\"type\":\"string\"}}]}",
                SupportPlanId = "U291cmNlOlNDTSxDbGFyaWZ5SW5zdGFsbGF0aW9uU2l0ZUlkOjcsTGluZUl0ZW1JZDo5ODY1NzIyOSxDb250cmFjdElkOjk4NjU5MTk0LFN1YnNjcmlwdGlvbklkOjc2Y2I3N2ZhLThiMTctNGVhYi05NDkzLWI2NWRhY2U5OTgxMyw=",
                ContactDetails = new SupportContactProfile("abc", "xyz", PreferredContactMethod.Email, "abc@contoso.com", "Pacific Standard Time", "usa", "en-US"),
                Title = "my title",
                ServiceId = "/providers/Microsoft.Support/services/cddd3eb5-1830-b494-44fd-782f691479dc",
                FileWorkspaceName = "6f16735c-1530836f-e9970f1a-2e49-47b7-96cd-9746b83aa066",
                SecondaryConsent =
{
new SecondaryConsent()
{
UserConsent = UserConsent.Yes,
SecondaryConsentType = "virtualmachinerunninglinuxservice",
}
},
            };
            ArmOperation<TenantSupportTicketResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, supportTicketName, data);
            TenantSupportTicketResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
