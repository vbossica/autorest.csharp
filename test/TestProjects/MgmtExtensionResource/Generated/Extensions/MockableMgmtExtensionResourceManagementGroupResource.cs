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
using MgmtExtensionResource;

namespace MgmtExtensionResource.Mocking
{
    /// <summary> A class to add extension methods to ManagementGroupResource. </summary>
    public partial class MockableMgmtExtensionResourceManagementGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMgmtExtensionResourceManagementGroupResource"/> class for mocking. </summary>
        protected MockableMgmtExtensionResourceManagementGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtExtensionResourceManagementGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtExtensionResourceManagementGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ManagementGroupPolicyDefinitionResources in the ManagementGroupResource. </summary>
        /// <returns> An object representing collection of ManagementGroupPolicyDefinitionResources and their operations over a ManagementGroupPolicyDefinitionResource. </returns>
        public virtual ManagementGroupPolicyDefinitionCollection GetManagementGroupPolicyDefinitions()
        {
            return GetCachedClient(client => new ManagementGroupPolicyDefinitionCollection(client, Id));
        }

        /// <summary>
        /// This operation retrieves the policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagementGroupPolicyDefinitionResource>> GetManagementGroupPolicyDefinitionAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            return await GetManagementGroupPolicyDefinitions().GetAsync(policyDefinitionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This operation retrieves the policy definition in the given management group with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PolicyDefinitions_GetAtManagementGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ManagementGroupPolicyDefinitionResource> GetManagementGroupPolicyDefinition(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            return GetManagementGroupPolicyDefinitions().Get(policyDefinitionName, cancellationToken);
        }
    }
}
