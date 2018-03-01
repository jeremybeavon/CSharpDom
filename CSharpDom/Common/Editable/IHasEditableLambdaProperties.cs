using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableLambdaProperties<TLambdaProperty> : IHasLambdaProperties<TLambdaProperty>
    {
        new ICollection<TLambdaProperty> LambdaProperties { get; set; }
    }
}
