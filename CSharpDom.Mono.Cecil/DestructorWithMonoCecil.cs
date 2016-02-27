using CSharpDom.BaseClasses;
using System.Reflection;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.NotSupported;

namespace CSharpDom.Mono.Cecil
{
    public sealed class DestructorWithMonoCecil :
        AbstractDestructor<AttributeWithMonoCecil, IClass, ILMethodBodyWithMonoCecilEmit>,
        IHasMethodInfo//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly IClass declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilEmit> body;

        internal DestructorWithMonoCecil(IClass declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            body = new Lazy<ILMethodBodyWithMonoCecilEmit>(() => new ILMethodBodyWithMonoCecilEmit(method));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override IClass DeclaringType
        {
            get { return declaringType; }
        }

        public MethodInfo MethodInfo
        {
            get { return method; }
        }

        public override ILMethodBodyWithMonoCecilEmit Body
        {
            get { return body.Value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDestructorWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
