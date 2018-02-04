using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> :
        IEditableGenericParameterDeclaration,
        IHasEditableName,
        IHasEditableAttributes<TAttributeGroup>,
        IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>
        where TClassReference : IEditableClassReference
        where TGenericParameterReference : IEditableGenericParameterReference
        where TInterfaceReference : IEditableInterfaceReference
        where TAttributeGroup : IEditableAttributeGroup
    {
        new GenericParameterDeclarationDirection Direction { get; set; }

        new GenericParameterTypeConstraint TypeConstraint { get; set; }

        new TClassReference BaseClassConstraint { get; set; }

        new ICollection<TGenericParameterReference> GenericParameterConstraints { get; set; }

        new ICollection<TInterfaceReference> InterfaceConstraints { get; set; }

        new bool HasEmptyConstructorConstraint { get; set; }
    }
}