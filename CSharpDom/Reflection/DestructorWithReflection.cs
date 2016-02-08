using CSharpDom.BaseClasses;
using System.Reflection;
using System;
using System.Collections.Generic;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection
{
    public sealed class DestructorWithReflection :
        AbstractDestructor<AttributeWithReflection, ClassWithReflection, ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ClassWithReflection declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> body;

        internal DestructorWithReflection(ClassWithReflection declaringType, MethodInfo method)
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

        public override ClassWithReflection DeclaringType
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
