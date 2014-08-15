using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasConstructors<TConstructor>
    {
        IReadOnlyCollection<TConstructor> Constructors { get; }
    }
}
