using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStaticClassFieldCollection<TFieldGroup, TConstantGroup> :
        IStaticClassFieldCollection,
        IReadOnlyCollection<TFieldGroup>,
        IHasConstants<TConstantGroup>
        where TFieldGroup : IStaticClassField
        where TConstantGroup : IStaticClassConstant
    {
    }
}
