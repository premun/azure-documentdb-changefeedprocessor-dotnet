//----------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  Licensed under the MIT license.
//----------------------------------------------------------------

namespace Microsoft.Azure.Documents.ChangeFeedProcessor.PartitionManagement
{
    using System.Threading.Tasks;

    internal interface IPartitionController
    {
        Task AddLeaseAsync(ILease lease);

        Task InitializeAsync();

        Task ShutdownAsync();
    }
}