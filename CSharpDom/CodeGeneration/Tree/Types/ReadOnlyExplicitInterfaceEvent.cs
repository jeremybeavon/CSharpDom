using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyExplicitInterfaceEvent :
        AbstractExplicitInterfaceEvent<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyInterfaceReference,
            ReadOnlyDelegateReference,
            ReadOnlyMethodBody>
    {
        private readonly ExplicitInterfaceEvent explicitInterfaceEvent;
        private readonly ReadOnlyInterfaceReference explicitInterface;
        private readonly ReadOnlyMethodBody addBody;
        private readonly ReadOnlyDelegateReference eventType;
        private readonly ReadOnlyMethodBody removeBody;

        public ReadOnlyExplicitInterfaceEvent(ExplicitInterfaceEvent explicitInterfaceEvent)
        {
            this.explicitInterfaceEvent = explicitInterfaceEvent;
            explicitInterface = new ReadOnlyInterfaceReference(explicitInterfaceEvent.ExplicitInterface);
            eventType = new ReadOnlyDelegateReference(explicitInterfaceEvent.Type);
            addBody = new ReadOnlyMethodBody(explicitInterfaceEvent.Accessors.AddBody);
            removeBody = new ReadOnlyMethodBody(explicitInterfaceEvent.Accessors.RemoveBody);
        }

        public override ReadOnlyMethodBody AddBody
        {
            get { return addBody; }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyDelegateReference EventType
        {
            get { return eventType; }
        }

        public override ReadOnlyInterfaceReference ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override string Name
        {
            get { return explicitInterface.Name; }
        }

        public override ReadOnlyMethodBody RemoveBody
        {
            get { return removeBody; }
        }
    }
}
