using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasParameterDefinition
    {
        ParameterDefinition ParameterDefinition { get; }
    }
}
