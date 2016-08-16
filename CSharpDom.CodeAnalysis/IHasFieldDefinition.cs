using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public interface IHasFieldDefinition
    {
        FieldDefinition FieldDefinition { get; }
    }
}
