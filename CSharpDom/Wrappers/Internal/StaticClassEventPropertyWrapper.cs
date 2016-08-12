using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassEventPropertyWrapper : AbstractWrapper<IStaticClassEventProperty>
    {
        public StaticClassEventPropertyWrapper(IStaticClassEventProperty eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Value = new StaticClassEventProperty()
            {
                AddAttributes = eventProperty.AddAttributes.ToAttributeListUsingWrapper(),
                AddBody = new MethodBodyWrapper(eventProperty.AddBody).Value,
                Attributes = eventProperty.Attributes.ToAttributeListUsingWrapper(),
                EventType = new DelegateReferenceWrapper(eventProperty.EventType).Value,
                Name = eventProperty.Name,
                RemoveAttributes = eventProperty.RemoveAttributes.ToAttributeListUsingWrapper(),
                RemoveBody = new MethodBodyWrapper(eventProperty.RemoveBody).Value,
                Visibility = eventProperty.Visibility
            };
        }
    }
}
