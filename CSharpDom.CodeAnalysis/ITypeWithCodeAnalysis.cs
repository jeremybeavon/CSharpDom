using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis
{
    public interface ITypeWithCodeAnalysis :
        IType,
        IHasTypeDefinition,
        IBasicTypeWithCodeAnalysis,
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
