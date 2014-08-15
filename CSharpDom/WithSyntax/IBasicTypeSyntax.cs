using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IBasicTypeSyntax :
        IHasEvents<IEventSyntax>,
        IHasProperties<IPropertySyntax>,
        IHasIndexers<IIndexerSyntax>,
        IHasMethods<IMethodSyntax>
    {
        bool IsNestedType { get; }
    }
}
