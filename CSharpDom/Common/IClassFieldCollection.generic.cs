using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassFieldCollection<TField, TConstant> :
        IClassFieldCollection,
        IReadOnlyCollection<TField>,
        IHasConstants<TConstant>
        where TField : IClassField
        where TConstant : IClassConstant
    {
    }
}
