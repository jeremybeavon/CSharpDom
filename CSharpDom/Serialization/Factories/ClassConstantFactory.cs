using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassConstantFactory : AbstractFactory<IClassConstant, ClassConstant>
    {
        public ClassConstantFactory(IClassConstant field)
            : base(field)
        {
        }

        public override void VisitClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
        {
            Value = new ClassConstant()
            {
                Attributes = field.Attributes.ToAttributeListUsingFactory(),
                Constants = field.Constants.ToList(child => new ConstantFactory(child).Value),
                FieldType = new TypeReferenceFactory(field.FieldType).Value,
                Visibility = field.Visibility
            };
        }
    }
}
