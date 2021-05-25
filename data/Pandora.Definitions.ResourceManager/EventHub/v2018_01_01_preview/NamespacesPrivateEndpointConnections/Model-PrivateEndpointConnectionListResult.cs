using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.NamespacesPrivateEndpointConnections
{

	internal class PrivateEndpointConnectionListResult
	{
		[JsonPropertyName("nextLink")]
		public string? NextLink { get; set; }

		[JsonPropertyName("value")]
		public List<PrivateEndpointConnection>? Value { get; set; }
	}
}