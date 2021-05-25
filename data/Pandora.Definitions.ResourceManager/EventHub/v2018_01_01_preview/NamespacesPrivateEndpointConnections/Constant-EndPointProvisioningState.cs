using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.EventHub.v2018_01_01_preview.NamespacesPrivateEndpointConnections
{
	[ConstantType(ConstantTypeAttribute.ConstantType.String)]
	internal enum EndPointProvisioningState
	{
		[Description("Canceled")]
		Canceled,

		[Description("Creating")]
		Creating,

		[Description("Deleting")]
		Deleting,

		[Description("Failed")]
		Failed,

		[Description("Succeeded")]
		Succeeded,

		[Description("Updating")]
		Updating,
	}
}