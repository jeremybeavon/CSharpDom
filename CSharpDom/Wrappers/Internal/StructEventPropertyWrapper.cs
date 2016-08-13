using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructEventPropertyWrapper : AbstractWrapper<IStructEventProperty>, IStructEventPropertyWrapper
    {
        public StructEventPropertyWrapper(IStructEventProperty eventProperty)
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

        public IStructTypeWrapper DeclaringType
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

        public StructMemberInheritanceModifier InheritanceModifier
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

        public StructMemberVisibilityModifier Visibility
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

        public override void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
        }
    }
}
