using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IHasPropertyDefinition
    {
        PropertyDefinition PropertyDefinition { get; }
    }
}
