using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasUsingDirectives<TUsingDirective>
    {
        IReadOnlyCollection<TUsingDirective> UsingDirectives { get; }
    }
}
