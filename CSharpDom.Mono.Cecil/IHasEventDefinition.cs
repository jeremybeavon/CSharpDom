using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasEventDefinition
    {
        EventDefinition EventDefinition { get; }
    }
}
