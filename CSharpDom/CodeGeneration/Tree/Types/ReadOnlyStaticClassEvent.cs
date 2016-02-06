using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStaticClassEvent :
        IStaticClassEvent<
            AttributeGroupNotSupported,
            IStaticType,
            ReadOnlyDelegateReference>,
        IStaticClassEventProperty<
            AttributeGroupNotSupported,
            IStaticType,
            ReadOnlyDelegateReference,
            ReadOnlyMethodBody>
    {
        private readonly StaticClassEvent classEvent;
        private readonly ReadOnlyMethodBody addBody;
        private readonly ReadOnlyDelegateReference eventType;
        private readonly ReadOnlyMethodBody removeBody;

        public ReadOnlyStaticClassEvent(StaticClassEvent classEvent)
        {
            this.classEvent = classEvent;
            eventType = new ReadOnlyDelegateReference(classEvent.Type);
            IsEventProperty = classEvent.Accessors != null;
            if (IsEventProperty)
            {
                addBody = new ReadOnlyMethodBody(classEvent.Accessors.AddBody);
                removeBody = new ReadOnlyMethodBody(classEvent.Accessors.RemoveBody);
            }
        }

        public ReadOnlyMethodBody AddBody
        {
            get { return addBody; }
        }

        public IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public IStaticType DeclaringType
        {
            get { return null; }
        }

        public ReadOnlyDelegateReference EventType
        {
            get { return eventType; }
        }

        public IReadOnlyCollection<AttributeGroupNotSupported> FieldAttributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }
        
        public string Name
        {
            get { return classEvent.Name; }
        }

        public ReadOnlyMethodBody RemoveBody
        {
            get { return removeBody; }
        }

        public StaticClassMemberVisibilityModifier Visibility
        {
            get { return classEvent.Visibility; }
        }
        
        public bool IsEventProperty { get; private set; }

        public void Accept(IGenericVisitor visitor)
        {
            if (IsEventProperty)
            {
                visitor.VisitStaticClassEventProperty(this);
            }
            else
            {
                visitor.VisitStaticClassEvent(this);
            }
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            if (IsEventProperty)
            {
                GenericVisitor.VisitEventPropertyChildren(this, visitor);
            }
            else
            {
                GenericVisitor.VisitEventChildren(this, visitor);
            }
        }
    }

}
