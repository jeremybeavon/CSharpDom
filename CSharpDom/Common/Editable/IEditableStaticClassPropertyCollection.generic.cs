using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty> :
        IEditableStaticClassPropertyCollection,
        ICollection<TProperty>,
        IHasEditableAutoProperties<TAutoProperty>,
        IHasEditableLambdaProperties<TLambdaProperty>,
        IStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty>
        where TProperty : IStaticClassProperty
        where TAutoProperty : IStaticClassAutoProperty
        where TLambdaProperty : IStaticClassLambdaProperty
    {
    }
}
