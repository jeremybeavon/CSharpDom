using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom.Serialization.Factories
{
    public static class ReadOnlyCollectionExtensions
    {
        public static List<AttributeGroup> ToAttributeListUsingFactory<TAttributeGroup>(
            this IReadOnlyCollection<TAttributeGroup> attributes)
            where TAttributeGroup : IAttributeGroup
        {
            return attributes.ToList(attribute => new AttributeGroupFactory(attribute).Value);
        }
    }
}
