using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassAccessorWithMonoCecil :
        AbstractClassAccessor<AttributeWithMonoCecil, ILMethodBodyWithMonoCecilEmit>,
        IHasMethodInfo
    {
        private readonly ClassMemberVisibilityModifier visibility;
        private readonly AccessorWithMonoCecil accessor;

        internal ClassAccessorWithMonoCecil(IHasClassMemberVisibilityModifier parentVisibility, AccessorWithMonoCecil accessor)
        {
            this.accessor = accessor;
            visibility = accessor.MethodInfo.ClassVisibility();
            if (parentVisibility.Visibility == visibility)
            {
                visibility = ClassMemberVisibilityModifier.None;
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return accessor.Attributes; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return visibility; }
        }

        public MethodInfo MethodInfo
        {
            get { return accessor.MethodInfo; }
        }

        public override ILMethodBodyWithMonoCecilEmit Body
        {
            get { return accessor.Body; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAccessorWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
