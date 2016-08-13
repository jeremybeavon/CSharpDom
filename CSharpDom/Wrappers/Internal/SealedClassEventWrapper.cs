using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassEventWrapper : AbstractWrapper<ISealedClassEvent>, ISealedClassEventWrapper
    {
        public SealedClassEventWrapper(ISealedClassEvent @event)
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

        public ISealedTypeWrapper DeclaringType
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

        public SealedClassMemberInheritanceModifier InheritanceModifier
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

        public ClassMemberVisibilityModifier Visibility
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

        public override void VisitSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
        }
    }
}
