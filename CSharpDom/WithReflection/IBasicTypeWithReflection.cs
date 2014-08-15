using CSharpDom.Common;

namespace CSharpDom.WithReflection
{
    public interface IBasicTypeWithReflection :
        IHasName,
        ICanBeGeneric,
        IHasType,
        IHasEvents<IEventWithReflection>,
        IHasProperties<IPropertyWithReflection>,
        IHasIndexers<IIndexerWithReflection>,
        IHasMethods<IMethodWithReflection>
    {
        bool IsNestedType { get; }
    }
}
