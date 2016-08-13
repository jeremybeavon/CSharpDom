using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class DestructorWrapper : AbstractWrapper<IDestructor>, IDestructorWrapper
    {
        public DestructorWrapper(IDestructor destructor)
            : base(destructor)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IMethodBodyWrapper Body
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IClassWrapper DeclaringType
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

        public override void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
        {
        }
    }
}
