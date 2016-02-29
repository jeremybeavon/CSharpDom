using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasAssemblyDefinition
    {
        AssemblyDefinition Assembly { get; }
    }
}
