using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassEventPropertyWrapper : AbstractWrapper<IClassEventProperty>
    {
        public ClassEventPropertyWrapper(IClassEventProperty eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Value = new ClassEventProperty()
            {
                AddAttributes = eventProperty.AddAttributes.ToAttributeListUsingWrapper(),
                AddBody = new MethodBodyWrapper(eventProperty.AddBody).Value,
                Attributes = eventProperty.Attributes.ToAttributeListUsingWrapper(),
                EventType = new DelegateReferenceWrapper(eventProperty.EventType).Value,
                InheritanceModifier = eventProperty.InheritanceModifier,
                Name = eventProperty.Name,
                RemoveAttributes = eventProperty.RemoveAttributes.ToAttributeListUsingWrapper(),
                RemoveBody = new MethodBodyWrapper(eventProperty.RemoveBody).Value,
                Visibility = eventProperty.Visibility
            };
        }
    }
}
