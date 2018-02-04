using CSharpDom.Common.Editable.Partial;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IEditableClassNestedClassCollection,
        IEditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>,
        IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IEditableClassNestedClass
        where TAbstractClass : IEditableClassNestedAbstractClass
        where TSealedClass : IEditableClassNestedSealedClass
        where TStaticClass : IEditableClassNestedStaticClass
        where TPartialClassCollection : IEditablePartialClassCollection
    {
    }
}