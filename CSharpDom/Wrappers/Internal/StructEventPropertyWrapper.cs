using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructEventPropertyWrapper : AbstractWrapper<IStructEventProperty>
    {
        public StructEventPropertyWrapper(IStructEventProperty eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Value = new StructEventProperty()
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
