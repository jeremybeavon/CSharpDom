using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassEvent :
        IClassEvent<
            AttributeGroupNotSupported,
            IClassType,
            ReadOnlyDelegateReference>,
        IClassEventProperty<
            AttributeGroupNotSupported,
            IClassType,
            ReadOnlyDelegateReference,
            ReadOnlyMethodBody>
    {
        private readonly ClassEvent classEvent;
        private readonly ReadOnlyMethodBody addBody;
        private readonly ReadOnlyDelegateReference eventType;
        private readonly ReadOnlyMethodBody removeBody;

        public ReadOnlyClassEvent(ClassEvent classEvent)
        {
            this.classEvent = classEvent;
            eventType = new ReadOnlyDelegateReference(classEvent.Type);
            if (classEvent.IsEventProperty)
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

        public IClassType DeclaringType
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

        public ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return classEvent.InheritanceModifier; }
        }

        public string Name
        {
            get { return classEvent.Name; }
        }

        public ReadOnlyMethodBody RemoveBody
        {
            get { return removeBody; }
        }

        public ClassMemberVisibilityModifier Visibility
        {
            get { return classEvent.Visibility; }
        }
        
        public void Accept(IGenericVisitor visitor)
        {
            if (classEvent.IsEventProperty)
            {
                visitor.VisitClassEventProperty(this);
            }
            else
            {
                visitor.VisitClassEvent(this);
            }
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            if (classEvent.IsEventProperty)
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
