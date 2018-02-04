using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableConversionOperators<TConversionOperator> : IHasConversionOperators<TConversionOperator>
    {
        new ICollection<TConversionOperator> ConversionOperators { get; set; }
    }
}