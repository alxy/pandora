using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Purview.v2021_07_01
{
    public partial class Definition : ApiVersionDefinition
    {
        public string ApiVersion => "2021-07-01";
        public bool Preview => false;

        public IEnumerable<ResourceDefinition> Apis => new List<ResourceDefinition>
        {
            new Account.Definition(),
            new DefaultAccount.Definition(),
            new PrivateEndpointConnection.Definition(),
            new PrivateLinkResource.Definition(),
            new Provider.Definition(),
        };
    }
}
