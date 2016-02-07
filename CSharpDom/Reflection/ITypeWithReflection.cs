using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public interface ITypeWithReflection :
        IType,
        IBasicTypeWithReflection,
        IStructType,
        IClassType,
        IAbstractType,
        IStaticType,
        ISealedType
    {
    }
}
