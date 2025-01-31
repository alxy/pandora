using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.LabServices.v2022_08_01.User;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum RegistrationStateConstant
{
    [Description("NotRegistered")]
    NotRegistered,

    [Description("Registered")]
    Registered,
}
