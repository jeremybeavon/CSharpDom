using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructEvent :
        IStructEvent<
            AttributeGroupNotSupported,
            IStructType,
            ReadOnlyDelegateReference>,
        IStructEventProperty<
            AttributeGroupNotSupported,
            IStructType,
            ReadOnlyDelegateReference,
            ReadOnlyMethodBody>
    {
        private readonly StructEvent structEvent;
        private readonly ReadOnlyMethodBody addBody;
        private readonly ReadOnlyDelegateReference eventType;
        private readonly ReadOnlyMethodBody removeBody;

        public ReadOnlyStructEvent(StructEvent structEvent)
        {
            this.structEvent = structEvent;
            eventType = new ReadOnlyDelegateReference(structEvent.Type);
            if (structEvent.IsEventProperty)
            {
                addBody = new ReadOnlyMethodBody(structEvent.Accessors.AddBody);
                removeBody = new ReadOnlyMethodBody(structEvent.Accessors.RemoveBody);
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

        public IStructType DeclaringType
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
            get { return structEvent.IsStatic ? ClassMemberInheritanceModifier.Static : ClassMemberInheritanceModifier.None; }
        }

        public string Name
        {
            get { return structEvent.Name; }
        }

        public ReadOnlyMethodBody RemoveBody
        {
            get { return removeBody; }
        }

        public StructMemberVisibilityModifier Visibility
        {
            get { return structEvent.Visibility; }
        }
        
        public void Accept(IGenericVisitor visitor)
        {
            if (structEvent.IsEventProperty)
            {
                visitor.VisitStructEventProperty(this);
            }
            else
            {
                visitor.VisitStructEvent(this);
            }
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            if (structEvent.IsEventProperty)
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
