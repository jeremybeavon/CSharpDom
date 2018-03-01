using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasLambdaProperties<TLambdaProperty>
    {
        IReadOnlyCollection<TLambdaProperty> LambdaProperties { get; }
    }
}
