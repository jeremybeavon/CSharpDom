using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticConstructorWrapper : AbstractWrapper<IStaticConstructor>
    {
        public StaticConstructorWrapper(IStaticConstructor constructor)
            : base(constructor)
        {
        }

        public override void VisitStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> staticConstructor)
        {
            Value = new StaticConstructor()
            {
                Attributes = staticConstructor.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(staticConstructor.Body).Value
            };
        }
    }
}
