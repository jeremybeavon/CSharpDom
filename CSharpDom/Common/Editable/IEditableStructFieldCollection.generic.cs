using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructFieldCollection<TFieldGroup, TConstantGroup> :
        IEditableStructFieldCollection,
        ICollection<TFieldGroup>,
        IHasEditableConstants<TConstantGroup>,
        IStructFieldCollection<TFieldGroup, TConstantGroup>
        where TFieldGroup : IEditableStructField
        where TConstantGroup : IEditableStructConstant
    {
    }
}