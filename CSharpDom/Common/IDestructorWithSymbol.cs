using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IDestructorWithSymbol : IDestructor, IHasSymbol<IMethodSymbol>
    {
    }
}
