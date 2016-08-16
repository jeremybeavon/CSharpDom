using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IHasAssemblyDefinition
    {
        AssemblyDefinition Assembly { get; }
    }
}
