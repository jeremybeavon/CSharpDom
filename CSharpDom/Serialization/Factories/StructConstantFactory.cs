using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructConstantFactory : AbstractFactory<IStructConstant, StructConstant>
    {
        public StructConstantFactory(IStructConstant field)
            : base(field)
        {
        }

        public override void VisitStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
        {
            Value = new StructConstant()
            {
                Attributes = field.Attributes.ToAttributeListUsingFactory(),
                Constants = field.Constants.ToList(child => new ConstantFactory(child).Value),
                FieldType = new TypeReferenceFactory(field.FieldType).Value,
                Visibility = field.Visibility
            };
        }
    }
}
