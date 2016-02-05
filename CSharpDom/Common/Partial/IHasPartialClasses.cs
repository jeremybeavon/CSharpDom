using System.Collections.Generic;

namespace CSharpDom.Common.Partial
{
    public interface IHasPartialClasses<TClass>
    {
        IReadOnlyCollection<TClass> Classes { get; }
    }
}
