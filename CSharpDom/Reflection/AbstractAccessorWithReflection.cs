using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection.Internal;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class AbstractAccessorWithReflection :
        AbstractAbstractAccessor<AttributeWithReflection>,
        IHasMethodInfo,
        IVisitable<IReflectionVisitor>,
        IStructAccessor
    {
        private readonly AccessorWithReflection accessor;

        internal AbstractAccessorWithReflection(IHasClassMemberVisibilityModifier parentVisibility, AccessorWithReflection accessor)
        {
            this.accessor = accessor;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return accessor.Attributes; }
        }
        
        public MethodInfo MethodInfo
        {
            get { return accessor.MethodInfo; }
        }
        
        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAbstractAccessorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
