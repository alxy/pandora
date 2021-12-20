using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.HandDefined.AADB2C.v2021_04_01_preview.Tenants
{
    internal class ResourceGroupId : ResourceID
    {
        public string? CommonAlias => null;

        public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}";

        public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
        {
            new()
            {
                Name = "subscriptions",
                Type = ResourceIDSegmentType.Static,
                FixedValue = "subscriptions"
            },
            new()
            {
                Name = "subscriptionId",
                Type = ResourceIDSegmentType.SubscriptionId
            },
            new()
            {
                Name = "resourceGroups",
                Type = ResourceIDSegmentType.Static,
                FixedValue = "resourceGroups"
            },
            new()
            {
                Name = "resourceGroup",
                Type = ResourceIDSegmentType.ResourceGroup
            },
        };
    }
}