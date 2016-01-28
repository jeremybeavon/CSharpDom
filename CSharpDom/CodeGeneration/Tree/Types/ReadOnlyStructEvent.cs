using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructEvent :
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
        private readonly StructEvent structEvent;
        private readonly ReadOnlyMethodBody addBody;
        private readonly ReadOnlyDelegateReference eventType;
        private readonly ReadOnlyMethodBody removeBody;

        public ReadOnlyStructEvent(StructEvent structEvent)
        {
            this.structEvent = structEvent;
            eventType = new ReadOnlyDelegateReference(structEvent.Type);
            IsEventProperty = structEvent.Accessors != null;
            if (IsEventProperty)
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
            get { return structEvent.IsStatic ? MemberInheritanceModifier.Static : MemberInheritanceModifier.None; }
        }

        public string Name
        {
            get { return structEvent.Name; }
        }

        public ReadOnlyMethodBody RemoveBody
        {
            get { return removeBody; }
        }

        public MemberVisibilityModifier Visibility
        {
            get { return ReadOnlyStruct.GetVisibility(structEvent.Visibility); }
        }

        IBasicType IHasDeclaringType<IBasicType>.DeclaringType
        {
            get { return null; }
        }

        public bool IsEventProperty { get; private set; }

        public void Accept(IGenericVisitor visitor)
        {
            if (IsEventProperty)
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
