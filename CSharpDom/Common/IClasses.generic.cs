namespace CSharpDom.Common
{
    public interface IClasses<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        IClasses,
        IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IClass
        where TAbstractClass : IAbstractClass
        where TSealedClass: ISealedClass
        where TStaticClass : IStaticClass
    {
    }
}
