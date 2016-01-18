using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface IBasicTypeSyntax :
        IBasicType<IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax>
    {
        bool IsNestedType { get; }
    }
}
