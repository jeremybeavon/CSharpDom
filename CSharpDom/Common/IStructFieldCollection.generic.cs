using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructFieldCollection<TFieldGroup, TConstantGroup> :
        IStructFieldCollection,
        IReadOnlyCollection<TFieldGroup>,
        IHasConstants<TConstantGroup>
        where TFieldGroup : IStructField
        where TConstantGroup : IStructConstant
    {
    }
}
