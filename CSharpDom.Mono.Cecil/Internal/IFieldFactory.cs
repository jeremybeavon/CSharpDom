using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    public interface IFieldFactory<TField, TConstant, TType>
        where TType : ITypeWithMonoCecil
    {
        TConstant CreateConstant(TType declaringType, FieldDefinition field);

        TField CreateField(TType declaringType, FieldDefinition field);
    }
}
