using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasAbstractClasses<TAbstractClass>
    {
        IReadOnlyCollection<TAbstractClass> AbstractClasses { get; }
    }
}
