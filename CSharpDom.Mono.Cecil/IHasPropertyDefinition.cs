using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasPropertyDefinition
    {
        PropertyDefinition PropertyDefinition { get; }
    }
}
