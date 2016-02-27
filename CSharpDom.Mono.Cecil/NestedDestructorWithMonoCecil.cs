using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class NestedDestructorWithMonoCecil :
        AbstractNestedDestructor<AttributeWithMonoCecil, INestedClass, ILMethodBodyWithMonoCecilEmit>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly INestedClass declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilEmit> body;

        internal NestedDestructorWithMonoCecil(INestedClass declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            body = new Lazy<ILMethodBodyWithMonoCecilEmit>(() => new ILMethodBodyWithMonoCecilEmit(method));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ILMethodBodyWithMonoCecilEmit Body
        {
            get { return body.Value; }
        }

        public override INestedClass DeclaringType
        {
            get { return declaringType; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedDestructorWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
