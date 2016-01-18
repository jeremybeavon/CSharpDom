using System.Collections.ObjectModel;

namespace CSharpDom.CodeAnalysis
{
    internal interface ITypeContainer
    {
        Collection<ClassNode> Classes { get; }

        Collection<DelegateNode> Delegates { get; }

        Collection<EnumNode> Enums { get; }

        Collection<InterfaceNode> Interfaces { get; }

        Collection<StructNode> Structs { get; }
    }
}
