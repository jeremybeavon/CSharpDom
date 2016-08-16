using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DestructorWithCodeAnalysis :
        AbstractDestructor<AttributeGroupWithCodeAnalysis, IClass, MethodBodyWithCodeAnalysis>,
        IHasMethodDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly IClass declaringType;
        private readonly MethodDefinition method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<MethodBodyWithCodeAnalysis> body;

        internal DestructorWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, IClass declaringType, MethodDefinition method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
            body = new Lazy<MethodBodyWithCodeAnalysis>(() => new MethodBodyWithCodeAnalysis(method));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override IClass DeclaringType
        {
            get { return declaringType; }
        }

        public MethodDefinition MethodDefinition
        {
            get { return method; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDestructorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
