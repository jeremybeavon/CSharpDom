using CSharpDom.BaseClasses;
using System.Reflection;
using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection
{
    public sealed class DestructorWithReflection :
        AbstractDestructor<AttributeWithReflection, IClass, ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly IClass declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> body;

        internal DestructorWithReflection(IClass declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            body = new Lazy<ILMethodBodyWithReflectionEmit>(() => new ILMethodBodyWithReflectionEmit(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override IClass DeclaringType
        {
            get { return declaringType; }
        }

        public MethodInfo MethodInfo
        {
            get { return method; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return body.Value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDestructorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
