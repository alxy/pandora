using System;
using System.Linq.Expressions;

namespace Pandora.Definitions.Mappings;

public class FromMapping
{
    /// <summary>
    /// FromModel is the name of the SchemaModel that this mapping is From.
    /// </summary>
    internal string FromModel { get; set; }

    /// <summary>
    /// FromFieldPath is the path to the SchemaField that this mapping is From.
    /// </summary>
    internal string FromFieldPath { get; set; }

    public ResourceIdMapping ToResourceIdSegmentNamed(string name)
    {
        if (FromFieldPath.Contains('.'))
        {
            throw new NotSupportedException("ResourceIDSegments can only be mapped to top-level fields");
        }

        return new ResourceIdMapping
        {
            SchemaFieldName = FromFieldPath,
            SegmentName = name,
        };
    }

    public MappingType ToSdkField<TModel>(Expression<Func<TModel, object>> schemaModelFieldFunc)
    {
        throw new NotSupportedException();
    }
}