using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassEventPropertyWrapper : AbstractWrapper<ISealedClassEventProperty>
    {
        public SealedClassEventPropertyWrapper(ISealedClassEventProperty eventProperty)
            : base(eventProperty)
        {
        }

        public override void VisitSealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            ISealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            Value = new SealedClassEventProperty()
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
