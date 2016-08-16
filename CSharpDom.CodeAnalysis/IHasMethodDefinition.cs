using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IHasMethodDefinition
    {
        MethodDefinition MethodDefinition { get; }
    }
}
