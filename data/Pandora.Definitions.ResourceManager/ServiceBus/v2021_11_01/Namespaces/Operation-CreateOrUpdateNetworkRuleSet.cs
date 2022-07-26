using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ServiceBus.v2021_11_01.Namespaces;

internal class CreateOrUpdateNetworkRuleSetOperation : Operations.PutOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(NetworkRuleSetModel);

    public override ResourceID? ResourceId() => new NamespaceId();

    public override Type? ResponseObject() => typeof(NetworkRuleSetModel);

    public override string? UriSuffix() => "/networkRuleSets/default";


}
