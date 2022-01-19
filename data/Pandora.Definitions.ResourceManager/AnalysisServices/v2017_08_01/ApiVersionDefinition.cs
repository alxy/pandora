using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.AnalysisServices.v2017_08_01
{
    public partial class Definition : ApiVersionDefinition
    {
        public string ApiVersion => "2017-08-01";
        public bool Preview => false;

        public IEnumerable<ResourceDefinition> Apis => new List<ResourceDefinition>
        {
            new AnalysisServices.Definition(),
            new Servers.Definition(),
        };
    }
}
