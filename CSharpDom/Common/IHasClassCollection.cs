using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasClassCollection<TClasses>
    {
        TClasses Classes { get; }
    }
}
