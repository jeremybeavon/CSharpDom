using CSharpDom.BaseClasses;
using System.Reflection;
using System;
using System.Collections.Generic;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class DestructorWithReflection :
        AbstractDestructor<AttributeWithReflection, ClassWithReflection>,
        IHasMethodInfo,
        IVisitable<IReflectionVisitor>
    {
        private readonly ClassWithReflection declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;

        internal DestructorWithReflection(ClassWithReflection declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
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


        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDestructorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
