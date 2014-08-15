using CSharpDom.Common;

namespace CSharpDom.WithSymbols
{
    public interface IBasicTypeWithSymbols :
        IHasEvents<IEventWithSymbols>,
        IHasProperties<IPropertyWithSymbols>,
        IHasIndexers<IIndexerWithSymbols>,
        IHasMethods<IMethodWithSymbols>
    {
        bool IsNestedType { get; }
    }
}
