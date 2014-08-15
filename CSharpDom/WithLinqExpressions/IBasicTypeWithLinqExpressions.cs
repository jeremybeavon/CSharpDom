using CSharpDom.Common;

namespace CSharpDom.WithLinqExpressions
{
    public interface IBasicTypeWithLinqExpressions :
        IHasEvents<IEventWithLinqExpressions>,
        IHasProperties<IPropertyWithLinqExpressions>,
        IHasIndexers<IIndexerWithLinqExpressions>,
        IHasMethods<IMethodWithLinqExpressions>
    {
        bool IsNestedType { get; }
    }
}
