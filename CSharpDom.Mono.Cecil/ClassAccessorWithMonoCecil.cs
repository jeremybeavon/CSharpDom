using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassAccessorWithMonoCecil :
        AbstractClassAccessor<AttributeWithMonoCecil, ILMethodBodyWithMonoCecilCil>,
        IHasMethodDefinition
    {
        private readonly ClassAccessorVisibilityModifier visibility;
        private readonly AccessorWithMonoCecil accessor;

        internal ClassAccessorWithMonoCecil(IHasClassMemberVisibilityModifier parentVisibility, AccessorWithMonoCecil accessor)
        {
            this.accessor = accessor;
            ClassMemberVisibilityModifier classVisibility = accessor.MethodDefinition.ClassVisibility();
            if (parentVisibility.Visibility == classVisibility)
            {
                visibility = ClassAccessorVisibilityModifier.None;
            }
            else
            {
                switch (classVisibility)
                {
                    case ClassMemberVisibilityModifier.Internal:
                        visibility = ClassAccessorVisibilityModifier.Internal;
                        break;
                    case ClassMemberVisibilityModifier.ProtectedInternal:
                        visibility = ClassAccessorVisibilityModifier.ProtectedInternal;
                        break;
                    case ClassMemberVisibilityModifier.Protected:
                        visibility = ClassAccessorVisibilityModifier.Protected;
                        break;
                    case ClassMemberVisibilityModifier.Private:
                        visibility = ClassAccessorVisibilityModifier.Private;
                        break;
                }
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return accessor.Attributes; }
        }

        public override ClassAccessorVisibilityModifier Visibility
        {
            get { return visibility; }
        }

        public MethodDefinition MethodDefinition
        {
            get { return accessor.MethodDefinition; }
        }

        public override ILMethodBodyWithMonoCecilCil Body
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
