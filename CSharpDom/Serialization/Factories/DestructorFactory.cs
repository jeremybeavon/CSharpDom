using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class DestructorFactory : AbstractFactory<IDestructor, Destructor>
    {
        public DestructorFactory(IDestructor destructor)
            : base(destructor)
        {
        }

        public override void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
        {
            Value = new Destructor()
            {
                Attributes = destructor.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(destructor.Body).Value
            };
        }
    }
}
