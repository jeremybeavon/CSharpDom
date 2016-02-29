using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasFieldDefinition
    {
        FieldDefinition FieldDefinition { get; }
    }
}
