using CSharpDom.Common.Editable.Partial;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IEditableStaticClassNestedClassCollection,
        IEditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>,
        IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IEditableStaticClassNestedClass
        where TAbstractClass : IEditableStaticClassNestedAbstractClass
        where TSealedClass : IEditableStaticClassNestedSealedClass
        where TStaticClass : IEditableStaticClassNestedStaticClass
        where TPartialClassCollection : IEditablePartialClassCollection
    {
    }
}