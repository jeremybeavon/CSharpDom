using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class NestedDestructorWrapper : AbstractWrapper<INestedDestructor>
    {
        public NestedDestructorWrapper(INestedDestructor nestedDestructor)
            : base(nestedDestructor)
        {
        }

        public override void VisitNestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> nestedDestructor)
        {
            Value = new NestedDestructor()
            {
                Attributes = nestedDestructor.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(nestedDestructor.Body).Value
            };
        }
    }
}
