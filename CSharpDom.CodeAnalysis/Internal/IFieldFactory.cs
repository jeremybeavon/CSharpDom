using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    public interface IFieldFactory<TField, TConstant, TType>
        where TType : ITypeWithCodeAnalysis
    {
        TConstant CreateConstant(TType declaringType, FieldDefinition field);

        TField CreateField(TType declaringType, FieldDefinition field);
    }
}
