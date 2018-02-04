using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableGenericParameters<TGenericParameter> : IHasGenericParameters<TGenericParameter>
    {
        new IList<TGenericParameter> GenericParameters { get; set; }
    }
}