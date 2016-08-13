using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructConstructorWrapper : AbstractWrapper<IStructConstructor>, IStructConstructorWrapper
    {
        public StructConstructorWrapper(IStructConstructor constructor)
            : base(constructor)
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

        public IStructTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<IConstructorParameterWrapper> Parameters
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

        public override void VisitStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
        }
    }
}
