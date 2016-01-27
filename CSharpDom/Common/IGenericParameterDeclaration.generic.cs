using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> :
        IGenericParameterDeclaration,
        IHasName,
        IHasAttributes<TAttributeGroup>
        where TClassReference : IClassReference
        where TGenericParameterReference : IGenericParameterReference
        where TInterfaceReference : IInterfaceReference
        where TAttributeGroup : IAttributeGroup
    {
        GenericParameterTypeConstraint TypeConstraint { get; }

        TClassReference BaseClassConstraint { get; }

        IReadOnlyCollection<TGenericParameterReference> GenericParameterConstraints { get; }

        IReadOnlyCollection<TInterfaceReference> InterfaceConstraints { get; }

        bool HasEmptyConstructorConstraint { get; }
    }
}
