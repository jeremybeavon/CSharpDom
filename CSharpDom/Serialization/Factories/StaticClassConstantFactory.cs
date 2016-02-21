using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassConstantFactory : AbstractFactory<IStaticClassConstant, StaticClassConstant>
    {
        public StaticClassConstantFactory(IStaticClassConstant field)
            : base(field)
        {
        }

        public override void VisitStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
        {
            Value = new StaticClassConstant()
            {
                Attributes = field.Attributes.ToAttributeListUsingFactory(),
                Constants = field.Constants.ToList(child => new ConstantFactory(child).Value),
                FieldType = new TypeReferenceFactory(field.FieldType).Value,
                Visibility = field.Visibility
            };
        }
    }
}
