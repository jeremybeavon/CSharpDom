using CSharpDom.Common;

namespace CSharpDom.Mono.Cecil
{
    public interface ITypeWithMonoCecil :
        IType,
        IHasTypeDefinition,
        IInterfaceTypeWithMonoCecil,
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
