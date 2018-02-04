using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassFieldCollection<TField, TConstant> :
        IEditableClassFieldCollection,
        ICollection<TField>,
        IHasEditableConstants<TConstant>,
        IClassFieldCollection<TField, TConstant>
        where TField : IEditableClassField
        where TConstant : IEditableClassConstant
    {
    }
}