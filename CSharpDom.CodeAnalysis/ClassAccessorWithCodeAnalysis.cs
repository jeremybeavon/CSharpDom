using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassAccessorWithCodeAnalysis :
        EditableClassAccessor<AttributeGroupWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasSyntax<AccessorDeclarationSyntax>
    {
        private readonly AccessorWithCodeAnalysis accessor;

        internal ClassAccessorWithCodeAnalysis(AccessorWithCodeAnalysis accessor)
        {
            this.accessor = accessor;
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return accessor.Attributes; }
            set { accessor.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return accessor.Body; }
            set { accessor.Body = value; }
        }

        public override ClassAccessorVisibilityModifier Visibility
        {
            get
            {
                ClassMemberVisibilityModifier parentVisibility = accessor.GetParent<IHasClassMemberVisibilityModifier>().Visibility;
                ClassMemberVisibilityModifier classVisibility = ClassMemberVisibilityModifier.None; //accessor.MethodDefinition.ClassVisibility();
                if (parentVisibility == classVisibility)
                {
                    return ClassAccessorVisibilityModifier.None;
                }
                else
                {
                    switch (classVisibility)
                    {
                        case ClassMemberVisibilityModifier.Internal:
                            return ClassAccessorVisibilityModifier.Internal;
                        case ClassMemberVisibilityModifier.ProtectedInternal:
                            return ClassAccessorVisibilityModifier.ProtectedInternal;
                        case ClassMemberVisibilityModifier.Protected:
                            return ClassAccessorVisibilityModifier.Protected;
                        case ClassMemberVisibilityModifier.Private:
                            return ClassAccessorVisibilityModifier.Private;
                    }
                }

                throw new InvalidOperationException();
            }
        }
        
        public AccessorDeclarationSyntax Syntax
        {
            get { return accessor.Syntax; }
            set { accessor.Syntax = value; }
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
