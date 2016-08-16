using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IHasParameterDefinition
    {
        ParameterDefinition ParameterDefinition { get; }
    }
}
