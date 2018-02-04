using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> :
        IEditableAttribute,
        IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>
        where TClassReference : IEditableClassReference
        where TUnnamedAttributeValue : IEditableUnnamedAttributeValue
        where TNamedAttributeValue : IEditableNamedAttributeValue
    {
        new TClassReference AttributeType { get; set; }

        new IList<TUnnamedAttributeValue> UnnamedValues { get; set; }

        new ICollection<TNamedAttributeValue> NamedValues { get; set; }
    }
}