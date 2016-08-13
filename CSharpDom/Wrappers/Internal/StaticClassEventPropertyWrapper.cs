using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassEventPropertyWrapper : AbstractWrapper<IStaticClassEventProperty>, IStaticClassEventPropertyWrapper
    {
        public StaticClassEventPropertyWrapper(IStaticClassEventProperty eventProperty)
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

        public override void VisitStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
        }
    }
}
