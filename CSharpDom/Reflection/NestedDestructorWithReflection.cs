using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class NestedDestructorWithReflection :
        AbstractNestedDestructor<AttributeWithReflection, INestedClass, MethodBodyNotSupported>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly NestedClassWithReflection declaringType;
        private readonly Lazy<Attributes> attributes;

        internal NestedDestructorWithReflection(NestedClassWithReflection declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override MethodBodyNotSupported Body
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override INestedClass DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /*public override NestedClassWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override MethodBodyNotSupported Body
        {
            get { return new MethodBodyNotSupported(); }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedDestructorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
