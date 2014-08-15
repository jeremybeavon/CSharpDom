using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasMethods<TMethod>
    {
        IReadOnlyCollection<TMethod> Methods { get; }
    }
}
