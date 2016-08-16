using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassAccessorWithCodeAnalysis :
        AbstractClassAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasMethodDefinition
    {
        private readonly ClassAccessorVisibilityModifier visibility;
        private readonly AccessorWithCodeAnalysis accessor;

        internal ClassAccessorWithCodeAnalysis(IHasClassMemberVisibilityModifier parentVisibility, AccessorWithCodeAnalysis accessor)
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

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
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

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return accessor.Body; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAccessorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
