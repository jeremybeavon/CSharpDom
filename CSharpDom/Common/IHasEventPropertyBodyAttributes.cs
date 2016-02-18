using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasEventPropertyBodyAttributes<TAttributeGroup>
    {
        IReadOnlyCollection<TAttributeGroup> AddAttributes { get; }

        IReadOnlyCollection<TAttributeGroup> RemoveAttributes { get; }
    }
}
