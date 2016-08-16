using System.Collections.ObjectModel;

namespace CSharpDom.CodeAnalysis
{
    internal interface IMemberContainer : IBasicMemberContainer, ITypeContainer, IHasCompositeType
    {
        Collection<FieldNode> Fields { get; }

        Collection<ConstructorNode> Constructors { get; }

        Collection<EventPropertyNode> EventProperties { get; }

        Collection<OperatorOverloadNode> OperatorOverloads { get; }

        Collection<ConversionOperatorNode> ConversionOperators { get; }
    }
}
