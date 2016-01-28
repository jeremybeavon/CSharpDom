using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public abstract class ReadOnlyClassEvent :
        IEvent<
            AttributeGroupNotSupported,
            IBasicType,
            ReadOnlyDelegateReference>,
        IEventProperty<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyDelegateReference,
            ReadOnlyMethodBody>
    {
        private readonly ClassEvent classEvent;
        private readonly bool isEventProperty;
        private readonly ReadOnlyMethodBody addBody;
        private readonly ReadOnlyDelegateReference eventType;
        private readonly ReadOnlyMethodBody removeBody;

        public ReadOnlyClassEvent(ClassEvent classEvent)
        {
            this.classEvent = classEvent;
            eventType = new ReadOnlyDelegateReference(classEvent.Type);
            isEventProperty = classEvent.Accessors != null;
            if (isEventProperty)
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

        public IType DeclaringType
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

        public MemberInheritanceModifier InheritanceModifier
        {
            get { return ReadOnlyClass.InheritanceModifier(classEvent.InheritanceModifier); }
        }

        public string Name
        {
            get { return classEvent.Name; }
        }

        public ReadOnlyMethodBody RemoveBody
        {
            get { return removeBody; }
        }

        public MemberVisibilityModifier Visibility
        {
            get { return ReadOnlyClass.Visibility(classEvent.Visibility); }
        }

        IBasicType IHasDeclaringType<IBasicType>.DeclaringType
        {
            get { return null; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            if (isEventProperty)
            {
                visitor.VisitEventProperty(this);
            }
            else
            {
                visitor.VisitEvent(this);
            }
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            if (isEventProperty)
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
