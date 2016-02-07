using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassAccessorFactory : AbstractFactory<IClassAccessor, ClassAccessor>
    {
        public ClassAccessorFactory(IClassAccessor accessor)
            : base(accessor)
        {
        }

        public override void VisitClassAccessor<TAttributeGroup, TMethodBody>(
            IClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            Value = new ClassAccessor()
            {
                Attributes = accessor.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(accessor.Body).Value//,
                //Visibility = accessor.Visibility
            };
        }
    }
}
