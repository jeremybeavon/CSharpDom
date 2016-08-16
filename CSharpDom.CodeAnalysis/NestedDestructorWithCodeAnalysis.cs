using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.CodeAnalysis.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedDestructorWithCodeAnalysis :
        AbstractNestedDestructor<AttributeGroupWithCodeAnalysis, INestedClass, MethodBodyWithCodeAnalysis>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly INestedClass declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<MethodBodyWithCodeAnalysis> body;

        internal NestedDestructorWithCodeAnalysis(INestedClass declaringType, MethodDefinition method)
        {
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(((ITypeWithCodeAnalysis)declaringType).Assembly, method));
            body = new Lazy<MethodBodyWithCodeAnalysis>(() => new MethodBodyWithCodeAnalysis(method));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
        }

        public override INestedClass DeclaringType
        {
            get { return declaringType; }
        }
        
        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedDestructorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
