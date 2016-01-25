using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasParameters<TParameter>
    {
        IReadOnlyList<TParameter> Parameters { get; }
    }
}
