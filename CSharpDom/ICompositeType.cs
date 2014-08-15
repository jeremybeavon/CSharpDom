using System.Collections.Generic;

namespace CSharpDom
{
    internal interface ICompositeType : IBasicCompositeType
    {
        IReadOnlyCollection<FieldNode> Fields { get; }

        IReadOnlyCollection<ConstructorNode> Constructors { get; }

        IReadOnlyCollection<EventPropertyNode> EventProperties { get; }

        IReadOnlyCollection<OperatorOverloadNode> OperatorOverloads { get; }

        IReadOnlyCollection<ConversionOperatorNode> ConversionOperators { get; }

        IReadOnlyCollection<ClassNode> Classes { get; }

        IReadOnlyCollection<DelegateNode> Delegates { get; }

        IReadOnlyCollection<EnumNode> Enums { get; }

        IReadOnlyCollection<InterfaceNode> Interfaces { get; }

        IReadOnlyCollection<StructNode> Structs { get; }
    }
}
