using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NestedDestructorFactory : AbstractFactory<INestedDestructor, NestedDestructor>
    {
        public NestedDestructorFactory(INestedDestructor nestedDestructor)
            : base(nestedDestructor)
        {
        }

        public override void VisitNestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> nestedDestructor)
        {
            Value = new NestedDestructor()
            {
                Attributes = nestedDestructor.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(nestedDestructor.Body).Value
            };
        }
    }
}
