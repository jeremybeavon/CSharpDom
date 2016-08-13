using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassEventWrapper : AbstractWrapper<IStaticClassEvent>, IStaticClassEventWrapper
    {
        public StaticClassEventWrapper(IStaticClassEvent @event)
            : base(@event)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStaticTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDelegateReferenceWrapper EventType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> FieldAttributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public StaticClassMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void VisitStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
        }
    }
}
