﻿// -----------------------------------------------------------------------
// <copyright file="AzureAccount.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.PowerShell.Profile
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public class AzureAccount
    {
        /// <summary>
        /// Get or sets the account identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets the account properties.
        /// </summary>
        public IDictionary<AzureAccountPropertyType, string> Properties { get; } = new ConcurrentDictionary<AzureAccountPropertyType, string>();

        /// <summary>
        /// Gets or sets the account type.
        /// </summary>
        public AccountType Type { get; set; }
    }
}