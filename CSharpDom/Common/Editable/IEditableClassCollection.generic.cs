using CSharpDom.Common.Editable.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IEditableClassCollection,
        ICollection<TClass>,
        IHasEditableAbstractClasses<TAbstractClass>,
        IHasEditableSealedClasses<TSealedClass>,
        IHasEditableStaticClasses<TStaticClass>,
        IHasEditablePartialClassCollection<TPartialClassCollection>,
        IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IEditableClass
        where TAbstractClass : IEditableAbstractClass
        where TSealedClass : IEditableSealedClass
        where TStaticClass : IEditableStaticClass
        where TPartialClassCollection : IEditablePartialClassCollection
    {
    }
}