using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class EventPropertyWrapper<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        AbstractEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IWrapper<IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public EventPropertyWrapper(IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> @event)
        {
            WrappedObject = @event;
        }

        public override IReadOnlyCollection<TAttributeGroup> AddAttributes
        {
            get { return WrappedObject.AddAttributes; }
        }

        public override TMethodBody AddBody
        {
            get { return WrappedObject.AddBody; }
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
        }

        public override TDelegateReference EventType
        {
            get { return WrappedObject.EventType; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
        }

        public override IReadOnlyCollection<TAttributeGroup> RemoveAttributes
        {
            get { return WrappedObject.RemoveAttributes; }
        }

        public override TMethodBody RemoveBody
        {
            get { return WrappedObject.RemoveBody; }
        }

        public IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> WrappedObject { get; private set; }
    }
}
