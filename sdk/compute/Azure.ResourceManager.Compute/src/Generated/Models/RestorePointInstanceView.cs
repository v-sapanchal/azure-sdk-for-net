// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of a restore point. </summary>
    public partial class RestorePointInstanceView
    {
        /// <summary> Initializes a new instance of RestorePointInstanceView. </summary>
        internal RestorePointInstanceView()
        {
            DiskRestorePoints = new ChangeTrackingList<DiskRestorePointInstanceView>();
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of RestorePointInstanceView. </summary>
        /// <param name="diskRestorePoints"> The disk restore points information. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal RestorePointInstanceView(IReadOnlyList<DiskRestorePointInstanceView> diskRestorePoints, IReadOnlyList<InstanceViewStatus> statuses)
        {
            DiskRestorePoints = diskRestorePoints;
            Statuses = statuses;
        }

        /// <summary> The disk restore points information. </summary>
        public IReadOnlyList<DiskRestorePointInstanceView> DiskRestorePoints { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
    }
}
