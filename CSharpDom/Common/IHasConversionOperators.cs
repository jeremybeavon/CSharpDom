using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasConversionOperators<TConversionOperator>
    {
        IReadOnlyCollection<TConversionOperator> ConversionOperators { get; }
    }
}
