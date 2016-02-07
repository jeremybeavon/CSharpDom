using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class AbstractAccessorWithReflection :
        AbstractAbstractAccessor<AttributeWithReflection>,
        IHasMethodInfo,
        //IVisitable<IReflectionVisitor>,
        IStructAccessor
    {
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;

        internal AbstractAccessorWithReflection(MethodInfo method)
        {
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }
        
        public MethodInfo MethodInfo
        {
            get { return method; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAccessorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
