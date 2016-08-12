using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class DestructorWrapper : AbstractWrapper<IDestructor>
    {
        public DestructorWrapper(IDestructor destructor)
            : base(destructor)
        {
        }

        public override void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
        {
            Value = new Destructor()
            {
                Attributes = destructor.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(destructor.Body).Value
            };
        }
    }
}
