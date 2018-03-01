using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty> :
        IStaticClassPropertyCollection,
        IReadOnlyCollection<TProperty>,
        IHasAutoProperties<TAutoProperty>,
        IHasLambdaProperties<TLambdaProperty>
        where TProperty : IStaticClassProperty
        where TAutoProperty : IStaticClassAutoProperty
        where TLambdaProperty : IStaticClassLambdaProperty
    {
    }
}
