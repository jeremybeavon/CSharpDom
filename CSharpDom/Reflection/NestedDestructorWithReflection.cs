using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class NestedDestructorWithReflection :
        AbstractNestedDestructor<AttributeWithReflection, INestedClass, ILMethodBodyWithReflectionEmit>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly INestedClass declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> body;

        internal NestedDestructorWithReflection(INestedClass declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            body = new Lazy<ILMethodBodyWithReflectionEmit>(() => new ILMethodBodyWithReflectionEmit(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return body.Value; }
        }

        public override INestedClass DeclaringType
        {
            get { return declaringType; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedDestructorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
