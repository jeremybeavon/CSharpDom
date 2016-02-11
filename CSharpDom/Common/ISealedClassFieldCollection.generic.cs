using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassFieldCollection<TFieldGroup, TConstantGroup> :
        ISealedClassFieldCollection,
        IReadOnlyCollection<TFieldGroup>,
        IHasConstants<TConstantGroup>
        where TFieldGroup : ISealedClassField
        where TConstantGroup : ISealedClassConstant
    {
    }
}
