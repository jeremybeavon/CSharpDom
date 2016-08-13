using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class NestedDestructorWrapper : AbstractWrapper<INestedDestructor>, INestedDestructorWrapper
    {
        public NestedDestructorWrapper(INestedDestructor nestedDestructor)
            : base(nestedDestructor)
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

        public INestedClassWrapper DeclaringType
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

        public override void VisitNestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> nestedDestructor)
        {
        }
    }
}
