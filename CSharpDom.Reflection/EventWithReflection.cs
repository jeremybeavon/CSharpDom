using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class EventWithReflection :
        AbstractEvent<AttributeWithReflection, IBasicTypeWithReflection, ITypeReferenceWithReflection>
    {
        internal EventWithReflection(IBasicTypeWithReflection declaringType, EventInfo @event)
        {
        }

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

        public override ITypeReferenceWithReflection EventType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> FieldAttributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override MemberInheritanceModifier InheritanceModifier
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

        public override MemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
