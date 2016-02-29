using CSharpDom.Common;

namespace CSharpDom.Mono.Cecil
{
    public interface ITypeWithMonoCecil :
        IType,
        IHasTypeDefinition,
        IBasicTypeWithMonoCecil,
        IStructType,
        IClassType,
        IAbstractType,
        IStaticType,
        ISealedType,
        IStaticClass,
        IHasAssembly
    {
    }
}
