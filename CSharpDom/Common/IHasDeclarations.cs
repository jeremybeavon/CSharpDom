using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasDeclarations<TDeclaration>
    {
        IReadOnlyCollection<TDeclaration> Declarations { get; }
    }
}
