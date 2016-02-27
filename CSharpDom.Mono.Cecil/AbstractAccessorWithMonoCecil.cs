using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AbstractAccessorWithMonoCecil :
        AbstractAbstractAccessor<AttributeWithMonoCecil>,
        IHasMethodInfo,
        //IVisitable<IReflectionVisitor>,
        IStructAccessor
    {
        private readonly AccessorWithMonoCecil accessor;

        internal AbstractAccessorWithMonoCecil(IHasClassMemberVisibilityModifier parentVisibility, AccessorWithMonoCecil accessor)
        {
            this.accessor = accessor;
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return accessor.Attributes; }
        }
        
        public MethodInfo MethodInfo
        {
            get { return accessor.MethodInfo; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAccessorWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
