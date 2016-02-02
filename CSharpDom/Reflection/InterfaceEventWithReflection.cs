using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceEventWithReflection :
        AbstractInterfaceEvent<
            AttributeWithReflection,
            IBasicTypeWithReflection,
            DelegateReferenceWithReflection>
    {
        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IBasicTypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override DelegateReferenceWithReflection EventType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
