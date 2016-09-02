using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyInterfaceEvent :
        AbstractInterfaceEvent<AttributeGroupNotSupported, IInterfaceType, ReadOnlyDelegateReference>
    {
        private readonly InterfaceEvent interfaceEvent;
        private readonly ReadOnlyDelegateReference eventType;

        public ReadOnlyInterfaceEvent(InterfaceEvent interfaceEvent)
        {
            this.interfaceEvent = interfaceEvent;
            eventType = new ReadOnlyDelegateReference(interfaceEvent.Type);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IInterfaceType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyDelegateReference EventType
        {
            get { return eventType; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                return interfaceEvent.IsNew ? InterfaceMemberInheritanceModifier.New : InterfaceMemberInheritanceModifier.None;
            }
        }

        public override string Name
        {
            get { return interfaceEvent.Name; }
        }
        
        public static IReadOnlyCollection<ReadOnlyInterfaceEvent> Create(IEnumerable<InterfaceEvent> interfaceEvents)
        {
            return interfaceEvents.ToArray(interfaceEvent => new ReadOnlyInterfaceEvent(interfaceEvent));
        }
    }
}
