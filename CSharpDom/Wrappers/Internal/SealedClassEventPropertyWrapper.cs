using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassEventPropertyWrapper : AbstractWrapper<ISealedClassEventProperty>, ISealedClassEventPropertyWrapper
    {
        public SealedClassEventPropertyWrapper(ISealedClassEventProperty eventProperty)
            : base(eventProperty)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> AddAttributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IMethodBodyWrapper AddBody
        {
            get
            {
                throw new NotImplementedException();
            }
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

        public IReadOnlyCollection<IAttributeGroupWrapper> RemoveAttributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IMethodBodyWrapper RemoveBody
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

        public override void VisitSealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            ISealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
        }
    }
}
