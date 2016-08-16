using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IHasEventDefinition
    {
        EventDefinition EventDefinition { get; }
    }
}
