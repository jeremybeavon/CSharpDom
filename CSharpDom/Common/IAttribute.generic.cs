using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> : IAttribute
        where TClassReference : IClassReference
        where TUnnamedAttributeValue : IUnnamedAttributeValue
        where TNamedAttributeValue : INamedAttributeValue
    {
        TClassReference AttributeType { get; }

        IReadOnlyList<TUnnamedAttributeValue> UnnamedValues { get; }

        IReadOnlyCollection<TNamedAttributeValue> NamedValues { get; }
    }
}
