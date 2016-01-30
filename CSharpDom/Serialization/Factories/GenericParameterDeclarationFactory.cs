using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class GenericParameterDeclarationFactory : AbstractFactory<IGenericParameterDeclaration, GenericParameterDeclaration>
    {
        public GenericParameterDeclarationFactory(IGenericParameterDeclaration genericParameterDeclaration)
            : base(genericParameterDeclaration)
        {
        }

        public override void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
        {
            Value = new GenericParameterDeclaration()
            {
                Attributes = genericParameterDeclaration.Attributes.ToAttributeListUsingFactory(),
                BaseClassConstraint = new ClassReferenceFactory(genericParameterDeclaration.BaseClassConstraint).Value,
                GenericParameterConstraints = genericParameterDeclaration.GenericParameterConstraints.ToList(constraint => new GenericParameterReferenceFactory(constraint).Value),
                HasEmptyConstructorConstraint = genericParameterDeclaration.HasEmptyConstructorConstraint,
                InterfaceConstraints = genericParameterDeclaration.InterfaceConstraints.ToList(constraint => new InterfaceReferenceFactory(constraint).Value),
                Name = genericParameterDeclaration.Name,
                TypeConstraint = genericParameterDeclaration.TypeConstraint
            };
        }
    }
}
