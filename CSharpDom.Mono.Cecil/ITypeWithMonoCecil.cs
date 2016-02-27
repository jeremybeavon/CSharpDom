using CSharpDom.Common;

namespace CSharpDom.Mono.Cecil
{
    public interface ITypeWithMonoCecil :
        IType,
        IHasType,
        IBasicTypeWithMonoCecil,
        IStructType,
        IClassType,
        IAbstractType,
        IStaticType,
        ISealedType,
        IStaticClass
    {
    }
}
