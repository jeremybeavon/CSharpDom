using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassAccessorWithReflection :
        AbstractSealedClassAccessor<AttributeWithReflection, ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo,
        //IVisitable<IReflectionVisitor>,
        IStructAccessor
    {
        private readonly SealedClassMemberVisibilityModifier visibility;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> body;

        internal SealedClassAccessorWithReflection(IHasSealedClassMemberVisibilityModifier parentVisibility, MethodInfo method)
        {
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            visibility = method.SealedClassVisibility();
            if (parentVisibility.Visibility == visibility)
            {
                visibility = SealedClassMemberVisibilityModifier.None;
            }

            body = new Lazy<ILMethodBodyWithReflectionEmit>(() => new ILMethodBodyWithReflectionEmit(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override SealedClassMemberVisibilityModifier Visibility
        {
            get { return visibility; }
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
            visitor.VisitAccessorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
