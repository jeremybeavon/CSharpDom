using CSharpDom.Common.Editable.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IEditableNestedClassCollection,
        ICollection<TClass>,
        IHasEditableAbstractClasses<TAbstractClass>,
        IHasEditableSealedClasses<TSealedClass>,
        IHasEditableStaticClasses<TStaticClass>,
        IHasEditablePartialClassCollection<TPartialClassCollection>,
        INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IEditableNestedClass
        where TAbstractClass : IEditableNestedAbstractClass
        where TSealedClass : IEditableNestedSealedClass
        where TStaticClass : IEditableNestedStaticClass
        where TPartialClassCollection : IEditablePartialClassCollection
    {
    }
}