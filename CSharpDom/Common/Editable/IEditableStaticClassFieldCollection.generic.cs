using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassFieldCollection<TFieldGroup, TConstantGroup> :
        IEditableStaticClassFieldCollection,
        ICollection<TFieldGroup>,
        IHasEditableConstants<TConstantGroup>,
        IStaticClassFieldCollection<TFieldGroup, TConstantGroup>
        where TFieldGroup : IEditableStaticClassField
        where TConstantGroup : IEditableStaticClassConstant
    {
    }
}