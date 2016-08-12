using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class GenericParameterDeclarationWrapper : AbstractWrapper<IGenericParameterDeclaration>
    {
        public GenericParameterDeclarationWrapper(IGenericParameterDeclaration genericParameterDeclaration)
            : base(genericParameterDeclaration)
        {
        }

        public override void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
        {
            Value = new GenericParameterDeclaration()
            {
                Attributes = genericParameterDeclaration.Attributes.ToAttributeListUsingWrapper(),
                BaseClassConstraint = new ClassReferenceWrapper(genericParameterDeclaration.BaseClassConstraint).Value,
                GenericParameterConstraints = genericParameterDeclaration.GenericParameterConstraints.ToList(constraint => new GenericParameterReferenceWrapper(constraint).Value),
                HasEmptyConstructorConstraint = genericParameterDeclaration.HasEmptyConstructorConstraint,
                InterfaceConstraints = genericParameterDeclaration.InterfaceConstraints.ToList(constraint => new InterfaceReferenceWrapper(constraint).Value),
                Name = genericParameterDeclaration.Name,
                TypeConstraint = genericParameterDeclaration.TypeConstraint
            };
        }
    }
}
