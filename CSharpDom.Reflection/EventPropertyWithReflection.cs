using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class EventPropertyWithReflection : AbstractEventProperty<AttributeWithReflection, ITypeWithReflection>
    {
        internal EventPropertyWithReflection(ITypeWithReflection declaringType, EventInfo @event)
        {
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeWithReflection DeclaringType
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
