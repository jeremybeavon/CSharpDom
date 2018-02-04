using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditablePartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass> :
        IEditablePartialClassCollection,
        IHasEditableClasses<TClass>,
        IHasEditableAbstractClasses<TAbstractClass>,
        IHasEditableSealedClasses<TSealedClass>,
        IHasEditableStaticClasses<TStaticClass>,
        IPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass>
        where TClass : IEditableClassType
        where TAbstractClass : IEditableAbstractType
        where TSealedClass : IEditableSealedType
        where TStaticClass : IEditableStaticType
    {
    }
}