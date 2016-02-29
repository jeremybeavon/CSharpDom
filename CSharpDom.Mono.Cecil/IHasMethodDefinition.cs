using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasMethodDefinition
    {
        MethodDefinition MethodDefinition { get; }
    }
}
