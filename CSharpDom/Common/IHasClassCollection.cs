using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasClassCollection<TClassCollection>
    {
        TClassCollection Classes { get; }
    }
}
