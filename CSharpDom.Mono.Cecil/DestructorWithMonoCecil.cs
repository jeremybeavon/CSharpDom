using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class DestructorWithMonoCecil :
        AbstractDestructor<AttributeWithMonoCecil, IClass, ILMethodBodyWithMonoCecilCil>,
        IHasMethodDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly IClass declaringType;
        private readonly MethodDefinition method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilCil> body;

        internal DestructorWithMonoCecil(AssemblyWithMonoCecil assembly, IClass declaringType, MethodDefinition method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
            body = new Lazy<ILMethodBodyWithMonoCecilCil>(() => new ILMethodBodyWithMonoCecilCil(method));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override IClass DeclaringType
        {
            get { return declaringType; }
        }

        public MethodDefinition MethodDefinition
        {
            get { return method; }
        }

        public override ILMethodBodyWithMonoCecilCil Body
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
