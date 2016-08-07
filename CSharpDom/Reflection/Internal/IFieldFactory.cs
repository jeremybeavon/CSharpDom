using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    public interface IFieldFactory<TField, TConstant, TType>
        where TType : ITypeWithReflection
    {
        TConstant CreateConstant(TType declaringType, FieldInfo field);

        TField CreateField(TType declaringType, FieldInfo field);
    }
}
