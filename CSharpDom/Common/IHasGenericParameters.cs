using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasGenericParameters<TGenericParameter>
    {
        IReadOnlyList<TGenericParameter> GenericParameters { get; }
    }
}
