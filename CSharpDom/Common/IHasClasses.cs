using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasClasses<TClass>
    {
        IReadOnlyCollection<TClass> Classes { get; }
    }
}
