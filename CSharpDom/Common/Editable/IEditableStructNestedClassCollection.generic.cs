using CSharpDom.Common.Editable.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IEditableStructNestedClassCollection,
        IEditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>,
        IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IEditableStructNestedClass
        where TAbstractClass : IEditableStructNestedAbstractClass
        where TSealedClass : IEditableStructNestedSealedClass
        where TStaticClass : IEditableStructNestedStaticClass
        where TPartialClassCollection : IEditablePartialClassCollection
    {
    }
}