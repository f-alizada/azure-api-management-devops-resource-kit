﻿// --------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  Licensed under the MIT License.
// --------------------------------------------------------------------------

using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Abstractions;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.IdentityProviders
{
    public class IdentityProviderTemplateResource : TemplateResource
    {
        public IdentityProviderTemplateProperties Properties { get; set; }
    }
}
