// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.NetworkInformation
{
    /// <summary>
    /// Provides information about a network interface's unicast address.
    /// </summary>
    public abstract class MulticastIPAddressInformation : IPAddressInformation
    {
        /// <summary>
        /// Gets the number of seconds remaining during which this address is the preferred address.
        /// </summary>
        public abstract long AddressPreferredLifetime { get; }

        /// <summary>
        /// Gets the number of seconds remaining during which this address is valid.
        /// </summary>
        public abstract long AddressValidLifetime { get; }

        /// <summary>
        /// Specifies the amount of time remaining on the Dynamic Host Configuration Protocol (DHCP) lease for this IP address.
        /// </summary>
        public abstract long DhcpLeaseLifetime { get; }

        /// <summary>
        /// Gets a value that indicates the state of the duplicate address detection algorithm.
        /// </summary>
        public abstract DuplicateAddressDetectionState DuplicateAddressDetectionState { get; }

        /// <summary>
        /// Gets a value that identifies the source of a unicast IP address prefix.
        /// </summary>
        public abstract PrefixOrigin PrefixOrigin { get; }

        /// <summary>
        /// Gets a value that identifies the source of a unicast IP address suffix.
        /// </summary>
        public abstract SuffixOrigin SuffixOrigin { get; }
    }
}
