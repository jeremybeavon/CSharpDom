using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public interface ITypeWithReflection :
        IType,
        IHasType,
        IBasicTypeWithReflection,
        IStructType,
        IClassType,
        IAbstractType,
        IStaticType,
        ISealedType,
        IStaticClass
    {
    }
}
