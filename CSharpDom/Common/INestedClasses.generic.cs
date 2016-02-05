namespace CSharpDom.Common
{
    public interface INestedClasses<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        INestedClasses,
        IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : INestedClass
        where TAbstractClass : INestedAbstractClass
        where TSealedClass: INestedSealedClass
        where TStaticClass : INestedStaticClass
    {
    }
}
