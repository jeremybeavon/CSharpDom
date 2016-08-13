using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticConstructorWrapper : AbstractWrapper<IStaticConstructor>, IStaticConstructorWrapper
    {
        public StaticConstructorWrapper(IStaticConstructor constructor)
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

        public ITypeWrapper DeclaringType
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

        public override void VisitStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> staticConstructor)
        {
        }
    }
}
